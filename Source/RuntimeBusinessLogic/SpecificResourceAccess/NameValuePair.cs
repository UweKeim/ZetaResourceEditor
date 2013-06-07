namespace ZetaResourceEditor.RuntimeBusinessLogic.SpecificResourceAccess
{
	/////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// 
	/// </summary>
	internal class NameValuePair
	{
		#region Public methods.
		// ------------------------------------------------------------------

		/// <summary>
		/// Initializes a new instance of the <see cref="NameValuePair"/> class.
		/// </summary>
		public NameValuePair()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="NameValuePair"/> class.
		/// </summary>
		/// <param name="name">The name.</param>
		public NameValuePair(
			string name )
		{
			Name = name;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="NameValuePair"/> class.
		/// </summary>
		/// <param name="name">The name.</param>
		/// <param name="value">The value.</param>
		public NameValuePair(
			string name,
			string value )
		{
			Name = name;
			Value = value;
		}

		// ------------------------------------------------------------------
		#endregion

		#region Public properties.
		// ------------------------------------------------------------------

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The value.</value>
		public string Value
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the tag.
		/// Use to store arbitrary objects.
		/// </summary>
		/// <value>The tag.</value>
		public object Tag
		{
			get;
			set;
		}

		// ------------------------------------------------------------------
		#endregion
	}

	/////////////////////////////////////////////////////////////////////////
}