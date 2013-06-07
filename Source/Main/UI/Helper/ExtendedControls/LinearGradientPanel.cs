namespace ZetaResourceEditor.UI.Helper.ExtendedControls
{
	#region Using directives.
	// ----------------------------------------------------------------------

	using System;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Drawing;
	using System.Drawing.Drawing2D;

	// ----------------------------------------------------------------------
	#endregion

	/////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// See also http://www.codeproject.com/cs/miscctrl/HeaderPanel.asp.
	/// </summary>
	public partial class LinearGradientPanel :
		Panel
	{
		#region Public methods.
		// ------------------------------------------------------------------

		/// <summary>
		///
		/// </summary>
		public LinearGradientPanel()
		{
			InitializeComponent();

			_startColor = Color.FromKnownColor( KnownColor.Window );
			_endColor = Color.FromKnownColor( KnownColor.Window );
			_gradientMode = LinearGradientMode.Vertical;

			SetStyle( ControlStyles.ResizeRedraw, true );
			SetStyle( ControlStyles.UserPaint, true );
			SetStyle( ControlStyles.AllPaintingInWmPaint, true );
			SetStyle( ControlStyles.DoubleBuffer, true );
		}

		// ------------------------------------------------------------------
		#endregion

		#region Public properties.
		// ------------------------------------------------------------------

		/// <summary>
		/// Gets or sets the gradient start.
		/// </summary>
		/// <value>The gradient start.</value>
		[Description( @"Change the starting color of gradient background" ),
		Category( @"Gradient" ),
		Browsable( true )]
		public Color GradientStart
		{
			get
			{
				return _startColor;
			}
			set
			{
				_startColor = value;
				Invalidate();
			}
		}

		/// <summary>
		/// Gets or sets the gradient end.
		/// </summary>
		/// <value>The gradient end.</value>
		[Description( @"Change the end color of gradient background" ),
		Category( @"Gradient" ),
		Browsable( true )]
		public Color GradientEnd
		{
			get
			{
				return _endColor;
			}
			set
			{
				_endColor = value;
				Invalidate();
			}
		}

		/// <summary>
		/// Gets or sets the gradient direction.
		/// </summary>
		/// <value>The gradient direction.</value>
		[Description( @"Change the background gradient direction" ),
		Category( @"Gradient" ),
		Browsable( true )]
		public LinearGradientMode GradientDirection
		{
			get
			{
				return _gradientMode;
			}
			set
			{
				_gradientMode = value;
				Invalidate();
			}
		}

		// ----------------------------------------------------------------------
		#endregion

		#region Private variables.
		// ------------------------------------------------------------------

		private Color _startColor;
		private Color _endColor;
		private LinearGradientMode _gradientMode;

		// ------------------------------------------------------------------
		#endregion

		#region Overrided methods.
		// ------------------------------------------------------------------

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Forms.Control.Resize"></see> event.
		/// </summary>
		/// <param name="e">An <see cref="T:System.EventArgs"></see> 
		/// that contains the event data.</param>
		protected override void OnResize(
			EventArgs e )
		{
			Invalidate();
			base.OnResize( e );
		}

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Forms.Control.Paint"></see> event.
		/// </summary>
		/// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs"></see>
		/// that contains the event data.</param>
		protected override void OnPaint(
			PaintEventArgs e )
		{
			if ( Width != 0 && Height != 0 )
			{
				base.OnPaint( e );

				if ( BackgroundImage == null )
				{
					drawBackground( e );
				}
			}
		}

		// ------------------------------------------------------------------
		#endregion

		#region Helper methods.
		// ------------------------------------------------------------------

		/// <summary>
		/// Draws the background.
		/// </summary>
		/// <param name="peArgs">The <see cref="System.Windows.Forms.PaintEventArgs"/> 
		/// instance containing the event data.</param>
		private void drawBackground(
			PaintEventArgs peArgs )
		{
			using ( Brush brsh = new LinearGradientBrush(
				new Rectangle(
				0, 0,
				Width, Height ),
				_startColor,
				_endColor,
				_gradientMode ) )
			{
				peArgs.Graphics.FillRectangle( brsh, 0, 0, Width, Height );
			}
		}

		// ------------------------------------------------------------------
		#endregion
	}

	/////////////////////////////////////////////////////////////////////////
}