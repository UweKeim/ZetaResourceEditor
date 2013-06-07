namespace ZetaResourceEditor.Runtime.Localization
{
	#region Public methods.
	// ----------------------------------------------------------------------
	using System;
	using System.Resources;
	using System.Reflection;
	using System.Globalization;
	using System.ComponentModel;

	// ----------------------------------------------------------------------
	#endregion

	/////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// Attribute for localization.
	/// </summary>
	[AttributeUsage(
		AttributeTargets.All,
		Inherited = false,
		AllowMultiple = true )]
	public sealed class LocalizableDisplayNameAttribute :
		DisplayNameAttribute
	{
		#region Public methods.
		// ------------------------------------------------------------------

		/// <summary>
		/// Initializes a new instance of the <see cref="LocalizableDisplayNameAttribute"/> class.
		/// </summary>
		/// <param name="displayName">The display name.</param>
		/// <param name="resourcesType">Type of the resources.</param>
		public LocalizableDisplayNameAttribute(
			string displayName,
			Type resourcesType )
			:
				base( displayName )
		{
			_resourcesType = resourcesType;
		}

		// ------------------------------------------------------------------
		#endregion

		#region Public properties.
		// ------------------------------------------------------------------

		/// <summary>
		/// Get the string value from the resources.
		/// </summary>
		/// <value></value>
		/// <returns>The display name.</returns>
		public override string DisplayName
		{
			get
			{
				if ( !_isLocalized )
				{
					var resMan =
						_resourcesType.InvokeMember(
							@"ResourceManager",
							BindingFlags.GetProperty | BindingFlags.Static |
								BindingFlags.Public | BindingFlags.NonPublic,
							null,
							null,
							new object[] {} ) as ResourceManager;

					var culture =
						_resourcesType.InvokeMember(
							@"Culture",
							BindingFlags.GetProperty | BindingFlags.Static |
								BindingFlags.Public | BindingFlags.NonPublic,
							null,
							null,
							new object[] {} ) as CultureInfo;

					_isLocalized = true;
					if ( resMan != null )
					{
						DisplayNameValue = resMan.GetString(
							DisplayNameValue,
							culture );
					}
				}

				return DisplayNameValue;
			}
		}

		// ------------------------------------------------------------------
		#endregion

		#region Private variables.
		// ------------------------------------------------------------------

		private readonly Type _resourcesType;
		private bool _isLocalized;

		// ------------------------------------------------------------------
		#endregion
	}

	/////////////////////////////////////////////////////////////////////////
}