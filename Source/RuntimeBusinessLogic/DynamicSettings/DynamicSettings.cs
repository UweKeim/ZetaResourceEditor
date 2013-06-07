namespace ZetaResourceEditor.RuntimeBusinessLogic.DynamicSettings
{
	using System;
	using System.Collections.Generic;
	using Zeta.EnterpriseLibrary.Tools.Storage;

	public class DynamicSettings :
		IPersistentPairStorage
	{
		public DynamicSettings(
			string prefix )
		{
			_prefix = prefix;
		}

		public string[] GetAllNames()
		{
			// Not needed now.
			return new string[] { };
		}

		public void MarkAsUnmodified()
		{
			_isModified = false;
		}

		public bool IsModified
		{
			get
			{
				return _isModified;
			}
		}

		private readonly Dictionary<string, string> _inMemoryValues =
			new Dictionary<string, string>();

		private readonly string _prefix;
		private bool _isModified;

		private string addPrefix( string name )
		{
			if ( string.IsNullOrEmpty( _prefix ) )
			{
				return name;
			}
			else
			{
				return _prefix + @"." + name;
			}
		}

		public Dictionary<string, string> DirectValues
		{
			get
			{
				return _inMemoryValues;
			}
		}

		public void PersistValue( string name, object value )
		{
			if ( string.IsNullOrEmpty( name ) )
			{
				throw new ArgumentNullException( @"name" );
			}
			else
			{
				if ( DirectValues.ContainsKey( addPrefix( name ) ) )
				{
					var current = DirectValues[addPrefix( name )];
					var adding = value == null ? null : value.ToString();

					if ( !isSame( current, adding ) )
					{
						DirectValues[addPrefix( name )] = adding;
						_isModified = true;
					}
				}
				else
				{
					DirectValues.Add( addPrefix( name ), value == null ? null : value.ToString() );
					_isModified = true;
				}
			}
		}

		private static bool isSame( string a, string b )
		{
			if ( a == null && b == null )
			{
				return true;
			}
			else
			{
				return a == b;
			}
		}

		public object RetrieveValue( string name )
		{
			if ( string.IsNullOrEmpty( name ) )
			{
				throw new ArgumentNullException( @"name" );
			}
			else
			{
				string result;
				if ( DirectValues.TryGetValue( addPrefix( name ), out result ) )
				{
					return result;
				}
				else
				{
					return null;
				}
			}
		}

		public object RetrieveValue( string name, object fallBackValue )
		{
			if ( string.IsNullOrEmpty( name ) )
			{
				throw new ArgumentNullException( @"name" );
			}
			else
			{
				string result;
				if ( DirectValues.TryGetValue( addPrefix( name ), out result ) )
				{
					return result;
				}
				else
				{
					return fallBackValue;
				}
			}
		}

		public void DeleteValue( string name )
		{
			if ( string.IsNullOrEmpty( name ) )
			{
				throw new ArgumentNullException( @"name" );
			}
			else
			{
				if ( DirectValues.ContainsKey( addPrefix( name ) ) )
				{
					if ( DirectValues.Remove( addPrefix( name ) ) )
					{
						_isModified = true;
					}
				}
			}
		}

		public void Flush()
		{
		}
	}
}