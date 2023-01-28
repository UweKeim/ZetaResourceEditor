namespace ZetaResourceEditorWebsite.RuntimeWeb.Code.Sys;

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

/// <summary>
/// A class for managing a weak event.
/// </summary>
/// <remarks>
/// See http://www.codeproject.com/KB/cs/WeakEvents.aspx.
/// </remarks>
public sealed class FastSmartWeakEvent<T>
    where T : class
{
    private readonly List<EventEntry> _eventEntries = new();

    static FastSmartWeakEvent()
    {
        if ( !typeof( T ).IsSubclassOf( typeof( Delegate ) ) )
        {
            throw new ArgumentException( @"T must be a delegate type." );
        }

        var invoke = typeof( T ).GetMethod( @"Invoke" );
        if ( invoke == null || invoke.GetParameters().Length != 2 )
        {
            throw new ArgumentException( @"T must be a delegate type taking 2 parameters." );
        }

        var senderParameter = invoke.GetParameters()[0];
        if ( senderParameter.ParameterType != typeof( object ) )
        {
            throw new ArgumentException( @"The first delegate parameter must be of type 'object'." );
        }

        var argsParameter = invoke.GetParameters()[1];
        if ( argsParameter.ParameterType != typeof( EventArgs ) &&
             !argsParameter.ParameterType.IsSubclassOf( typeof( EventArgs ) ) )
        {
            throw new ArgumentException( @"The second delegate parameter must be derived from type 'EventArgs'." );
        }
        if ( invoke.ReturnType != typeof( void ) )
        {
            throw new ArgumentException( @"The delegate return type must be void." );
        }
    }

    public void Add( T eh )
    {
        if ( eh != null )
        {
            var d = (Delegate)(object)eh;
            if ( _eventEntries.Count == _eventEntries.Capacity )
            {
                removeDeadEntries();
            }

            var target = d.Target != null ? new WeakReference( d.Target ) : null;

            _eventEntries.Add( new(
                FastSmartWeakEventForwarderProvider.GetForwarder( d.Method ), d.Method, target ) );
        }
    }

    private void removeDeadEntries()
    {
        _eventEntries.RemoveAll( ee => ee.TargetReference is { IsAlive: false } );
    }

    public void Remove( T eh )
    {
        if ( eh != null )
        {
            var d = (Delegate)(object)eh;

            for ( var i = _eventEntries.Count - 1; i >= 0; i-- )
            {
                var entry = _eventEntries[i];
                if ( entry.TargetReference != null )
                {
                    var target = entry.TargetReference.Target;
                    if ( target == null )
                    {
                        _eventEntries.RemoveAt( i );
                    }
                    else if ( target == d.Target && entry.TargetMethod == d.Method )
                    {
                        _eventEntries.RemoveAt( i );
                        break;
                    }
                }
                else
                {
                    if ( d.Target == null && entry.TargetMethod == d.Method )
                    {
                        _eventEntries.RemoveAt( i );
                        break;
                    }
                }
            }
        }
    }

    public void Raise( object sender, EventArgs e )
    {
        var needsCleanup = false;
        foreach ( var ee in _eventEntries.ToArray() )
        {
            needsCleanup |= ee.Forwarder( ee.TargetReference, sender, e );
        }

        if ( needsCleanup )
        {
            removeDeadEntries();
        }
    }

    #region Nested type: EventEntry

    private readonly struct EventEntry
    {
        public readonly FastSmartWeakEventForwarderProvider.ForwarderDelegate Forwarder;
        public readonly MethodInfo TargetMethod;
        public readonly WeakReference TargetReference;

        public EventEntry(
            FastSmartWeakEventForwarderProvider.ForwarderDelegate forwarder,
            MethodInfo targetMethod,
            WeakReference targetReference )
        {
            Forwarder = forwarder;
            TargetMethod = targetMethod;
            TargetReference = targetReference;
        }
    }

    #endregion
}

// The forwarder-generating code is in a separate class because it does not depend on type T.
internal static class FastSmartWeakEventForwarderProvider
{
    private static readonly Type[] _forwarderParameters =
    {
        typeof (WeakReference), 
        typeof (object), 
        typeof (EventArgs)
    };

    private static readonly Dictionary<MethodInfo, ForwarderDelegate> _forwarders =
        new();

    private static readonly MethodInfo _getTarget = typeof( WeakReference ).GetMethod( @"get_Target" );

    internal static ForwarderDelegate GetForwarder( MethodInfo method )
    {
        lock ( _forwarders )
        {
            if ( _forwarders.TryGetValue( method, out var d ) )
            {
                return d;
            }
        }

        if ( method.DeclaringType?.GetCustomAttributes(
                typeof( CompilerGeneratedAttribute ), false ).Length != 0 )
        {
            throw new ArgumentException( @"Cannot create weak event to anonymous method with closure." );
        }

        var dm = new DynamicMethod(
            @"FastSmartWeakEvent", typeof( bool ), _forwarderParameters, method.DeclaringType );

        var il = dm.GetILGenerator();

        if ( !method.IsStatic )
        {
            il.Emit( OpCodes.Ldarg_0 );
            il.EmitCall( OpCodes.Callvirt, _getTarget, null );
            il.Emit( OpCodes.Dup );

            var label = il.DefineLabel();
            il.Emit( OpCodes.Brtrue, label );
            il.Emit( OpCodes.Pop );
            il.Emit( OpCodes.Ldc_I4_1 );
            il.Emit( OpCodes.Ret );
            il.MarkLabel( label );
        }
        il.Emit( OpCodes.Ldarg_1 );
        il.Emit( OpCodes.Ldarg_2 );
        il.EmitCall( OpCodes.Call, method, null );
        il.Emit( OpCodes.Ldc_I4_0 );
        il.Emit( OpCodes.Ret );

        var fd = (ForwarderDelegate)dm.CreateDelegate( typeof( ForwarderDelegate ) );
        lock ( _forwarders )
        {
            _forwarders[method] = fd;
        }
        return fd;
    }

    #region Nested type: ForwarderDelegate

    internal delegate bool ForwarderDelegate(
        WeakReference wr,
        object sender,
        EventArgs e );

    #endregion
}