namespace ZetaResourceEditor.RuntimeBusinessLogic.DynamicSettings
{
	using Zeta.EnterpriseLibrary.Tools.Storage;

	public class DynamicSettingsHierarchical :
		IPersistentPairStorage
	{
		private readonly IPersistentPairStorage _parent;
		private readonly IPersistentPairStorage _regular;

		public DynamicSettingsHierarchical(
			IPersistentPairStorage regular,
			IPersistentPairStorage parent )
		{
			_regular = regular;
			_parent = parent;
		}

		public string[] GetAllNames()
		{
			// Not needed now.
			return new string[]{};
		}

		public void PersistValue( string name, object value )
		{
			_regular.PersistValue( name, value );
			_parent.PersistValue( name, value );
		}

		public object RetrieveValue( string name )
		{
			var r = _regular.RetrieveValue( name );

			return r ?? _parent.RetrieveValue( name );
		}

		public object RetrieveValue( string name, object fallBackValue )
		{
			var r = _regular.RetrieveValue( name, fallBackValue );
			return r == fallBackValue ? _parent.RetrieveValue( name, fallBackValue ) : r;
		}

		public void DeleteValue( string name )
		{
			_regular.DeleteValue( name );
			_parent.DeleteValue( name );
		}

		public void Flush()
		{
		}
	}
}