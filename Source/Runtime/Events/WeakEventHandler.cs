namespace ZetaResourceEditor.Runtime.Events
{
	using System;
	using System.Diagnostics.CodeAnalysis;

	public delegate void ZetaAction();

	public delegate void ZetaAction<in T1, in T2>(
		T1 arg1,
		T2 arg2
		);

	public delegate void ZetaAction<in T1, in T2, in T3>(
		T1 arg1,
		T2 arg2,
		T3 arg3
		);

	/// <summary>
	/// Helper class to add weak handlers to events of type System.EventHandler.
	/// </summary>
	/// <remarks>
	/// See http://www.codeproject.com/KB/cs/WeakEvents.aspx.
	/// </remarks>
	[SuppressMessage( @"Microsoft.Naming", @"CA1711:IdentifiersShouldNotHaveIncorrectSuffix" )]
	public sealed class WeakEventHandler
	{
		/// <summary>
		/// Registers an event handler that works with a weak reference to the target object.
		/// Access to the event and to the real event handler is done through lambda expressions.
		/// The code holds strong references to these expressions, so they must not capture any
		/// variables!
		/// </summary>
		/// <example>
		/// <code>
		/// WeakEventHandler.Register(
		/// 	textDocument,
		/// 	(d, eh) => d.Changed += eh,
		/// 	(d, eh) => d.Changed -= eh,
		/// 	this,
		/// 	(me, sender, args) => me.OnDocumentChanged(sender, args)
		/// );
		/// </code>
		/// </example>
		public static WeakEventHandler Register<TEventSource, TEventListener>(
			TEventSource senderObject,
			ZetaAction<TEventSource, EventHandler> registerEvent,
			ZetaAction<TEventSource, EventHandler> deregisterEvent,
			TEventListener listeningObject,
			ZetaAction<TEventListener, object, EventArgs> forwarderAction
			)
			where TEventSource : class
			where TEventListener : class
		{
			if ( senderObject == null )
				throw new ArgumentNullException( nameof(senderObject) );
			if ( listeningObject == null )
				throw new ArgumentNullException( nameof(listeningObject) );
			VerifyDelegate( registerEvent, @"registerEvent" );
			VerifyDelegate( deregisterEvent, @"deregisterEvent" );
			VerifyDelegate( forwarderAction, @"forwarderAction" );

			var weh = new WeakEventHandler( listeningObject );
			var eh = weh.MakeDeregisterCodeAndWeakEventHandler( senderObject, deregisterEvent, forwarderAction );
			registerEvent( senderObject, eh );
			return weh;
		}

		internal static void VerifyDelegate( Delegate d, string parameterName )
		{
			if ( d == null )
				throw new ArgumentNullException( parameterName );
			if ( !d.Method.IsStatic )
				throw new ArgumentException( "Delegates used for WeakEventHandler must not capture any variables (must point to static methods)", parameterName );
		}

		internal readonly WeakReference ListeningReference;
		internal ZetaAction DeregisterCode;

		internal WeakEventHandler( object listeningObject )
		{
			ListeningReference = new WeakReference( listeningObject );
		}

		EventHandler MakeDeregisterCodeAndWeakEventHandler
			<TEventSource, TEventListener>
			(
			TEventSource senderObject,
			ZetaAction<TEventSource, EventHandler> deregisterEvent,
			ZetaAction<TEventListener, object, EventArgs> forwarderAction
			)
			where TEventSource : class
			where TEventListener : class
		{
			EventHandler eventHandler = null;

			DeregisterCode = () => deregisterEvent(senderObject, eventHandler);

			eventHandler = ( sender, args ) =>
			               	{
			               		var listeningObject = (TEventListener)ListeningReference.Target;
			               		if ( listeningObject != null )
			               		{
			               			forwarderAction( listeningObject, sender, args );
			               		}
			               		else
			               		{
			               			Deregister();
			               		}
			               	};
			return eventHandler;
		}

		/// <summary>
		/// Deregisters the event handler.
		/// </summary>
		public void Deregister()
		{
			if ( DeregisterCode != null )
			{
				DeregisterCode();
				DeregisterCode = null;
			}
		}
	}

	/// <summary>
	/// Helper class to add weak handlers to events of type System.EventHandler{A}.
	/// </summary>
	[SuppressMessage( @"Microsoft.Naming", @"CA1711:IdentifiersShouldNotHaveIncorrectSuffix" )]
	public static class WeakEventHandler<TEventArgs>
		where TEventArgs : EventArgs
	{
		/// <summary>
		/// Registers an event handler that works with a weak reference to the target object.
		/// Access to the event and to the real event handler is done through lambda expressions.
		/// The code holds strong references to these expressions, so they must not capture any
		/// variables!
		/// </summary>
		/// <example>
		/// <code>
		/// WeakEventHandler&lt;DocumentChangeEventArgs&gt;.Register(
		/// 	textDocument,
		/// 	(d, eh) => d.Changed += eh,
		/// 	(d, eh) => d.Changed -= eh,
		/// 	this,
		/// 	(me, sender, args) => me.OnDocumentChanged(sender, args)
		/// );
		/// </code>
		/// </example>
		public static WeakEventHandler Register<TEventSource, TEventListener>(
			TEventSource senderObject,
			ZetaAction<TEventSource, EventHandler<TEventArgs>> registerEvent,
			ZetaAction<TEventSource, EventHandler<TEventArgs>> deregisterEvent,
			TEventListener listeningObject,
			ZetaAction<TEventListener, object, TEventArgs> forwarderAction
			)
			where TEventSource : class
			where TEventListener : class
		{
			if ( senderObject == null )
			{
				throw new ArgumentNullException( nameof(senderObject) );
			}
			if ( listeningObject == null )
			{
				throw new ArgumentNullException( nameof(listeningObject) );
			}
			WeakEventHandler.VerifyDelegate( registerEvent, @"registerEvent" );
			WeakEventHandler.VerifyDelegate( deregisterEvent, @"deregisterEvent" );
			WeakEventHandler.VerifyDelegate( forwarderAction, @"forwarderAction" );

			var weh = new WeakEventHandler( listeningObject );
			var eh = MakeDeregisterCodeAndWeakEventHandler( weh, senderObject, deregisterEvent, forwarderAction );
			registerEvent( senderObject, eh );
			return weh;
		}

		static EventHandler<TEventArgs> MakeDeregisterCodeAndWeakEventHandler
			<TEventSource, TEventListener>
			(
			WeakEventHandler weh,
			TEventSource senderObject,
			ZetaAction<TEventSource, EventHandler<TEventArgs>> deregisterEvent,
			ZetaAction<TEventListener, object, TEventArgs> forwarderAction
			)
			where TEventSource : class
			where TEventListener : class
		{
			EventHandler<TEventArgs> eventHandler = null;

			weh.DeregisterCode = () => deregisterEvent(senderObject, eventHandler);

			eventHandler = ( sender, args ) =>
			               	{
			               		var listeningObject = (TEventListener)weh.ListeningReference.Target;
			               		if ( listeningObject != null )
			               		{
			               			forwarderAction( listeningObject, sender, args );
			               		}
			               		else
			               		{
			               			weh.Deregister();
			               		}
			               	};
			return eventHandler;
		}
	}
}