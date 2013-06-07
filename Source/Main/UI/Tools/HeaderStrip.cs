using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ZetaResourceEditor.UI.Tools
{
	public class HeaderStrip :
		ToolStrip
	{
		private AreaHeaderStyle _headerStyle = AreaHeaderStyle.Large;
		private ToolStripProfessionalRenderer _pr;

		#region Public API
		public HeaderStrip()
		{
			// Check Dock
			base.Dock = DockStyle.Top;
			GripStyle = ToolStripGripStyle.Hidden;
			base.AutoSize = false;

			// Set renderer - override background painting
			SetRenderer();

			// Track Preference Changes
			Microsoft.Win32.SystemEvents.UserPreferenceChanged +=
				HeaderStrip_UserPreferenceChanged;

			// Setup Headers
			SetHeaderStyle();
		}

		[DefaultValue( AreaHeaderStyle.Large )]
		public AreaHeaderStyle HeaderStyle
		{
			get
			{
				return _headerStyle;
			}
			set
			{
				// Save value
				if ( _headerStyle != value )
				{
					_headerStyle = value;

					// Set Header Style
					SetHeaderStyle();
				}
			}
		}
		#endregion

		#region Overrides
		protected override void OnRendererChanged( EventArgs e )
		{
			// Call the base
			base.OnRendererChanged( e );

			// Work around bug_ with setting renderer in the constructor
			SetRenderer();
		}
		#endregion

		#region Private Implementation
		private void SetHeaderStyle()
		{
			// Get system font
			Font font = SystemFonts.MenuFont;

			if ( _headerStyle == AreaHeaderStyle.Large )
			{
				Font = new Font( @"Arial", font.SizeInPoints + 3.75F, FontStyle.Bold );
				ForeColor = Color.White;
			}
			else
			{
				Font = font;
				ForeColor = Color.White;
			}

			// Only way to calculate size
			var tsl = new ToolStripLabel {Font = Font, Text = @"I"};

			// Set Size
			Height = tsl.GetPreferredSize( Size.Empty ).Height + 6;
		}

		private void SetRenderer()
		{
			// Set renderer - override background painting
			if ( (Renderer is ToolStripProfessionalRenderer) && (Renderer != _pr) )
			{
				if ( _pr == null )
				{
					// Only swap out if we're setup to use a professional renderer
					_pr = new ToolStripProfessionalRenderer {RoundedEdges = false};

					// Square edges

					// Improve painting (use our colors)
					_pr.RenderToolStripBackground += Renderer_RenderToolStripBackground;
				}

				// User our renderer
				Renderer = _pr;
			}
		}
		#endregion

		#region Event Handlers
		void Renderer_RenderToolStripBackground(
			object sender,
			ToolStripRenderEventArgs e )
		{
			if ( Renderer is ToolStripProfessionalRenderer )
			{
				var pr =
					(ToolStripProfessionalRenderer)Renderer;

				// Setup colors from the provided renderer
				Color start;
				Color end;
				if ( _headerStyle == AreaHeaderStyle.Large )
				{
					start = pr.ColorTable.OverflowButtonGradientMiddle;
					end = pr.ColorTable.OverflowButtonGradientEnd;
				}
				else
				{
					start = pr.ColorTable.OverflowButtonGradientMiddle;
					end = pr.ColorTable.OverflowButtonGradientEnd;
				}

				// Size to paint
				var bounds = new Rectangle( Point.Empty, e.ToolStrip.Size );

				// Make sure we need to do work
				if ( (bounds.Width > 0) && (bounds.Height > 0) )
				{
					using ( Brush b = new LinearGradientBrush( 
						bounds, 
						start, 
						end, 
						LinearGradientMode.Vertical ) )
					{
						e.Graphics.FillRectangle( b, bounds );
					}
				}
			}
		}


		private void HeaderStrip_UserPreferenceChanged(
			object sender,
			Microsoft.Win32.UserPreferenceChangedEventArgs e )
		{
			SetHeaderStyle();
		}
		#endregion
	}

	public enum AreaHeaderStyle
	{
		Large = 0000,
		Small = 0001
	}
}