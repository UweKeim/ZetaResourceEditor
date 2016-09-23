namespace ZetaResourceEditor.UI.Helper.Base
{
	using System;
	using System.ComponentModel;
	using System.Diagnostics;
	using System.Globalization;
	using System.IO;
	using System.Text;
	using System.Windows.Forms;
	using DevExpress.XtraBars.Ribbon;
	using DevExpress.XtraEditors;
	using DevExpress.XtraSpellChecker;
	using DevExpress.XtraTab;
	using ExtendedControlsLibrary.General.Base;
	using Main;
	using RuntimeBusinessLogic.Language;
	using Zeta.VoyagerLibrary.Common;
	using Zeta.VoyagerLibrary.Tools.Storage;
	using Zeta.VoyagerLibrary.WinForms.Persistance;

	public partial class FormBase :
        DevExpressXtraFormBase
    {
		public FormBase()
		{
			InitializeComponent();
		}

		public static void ApplySpellCheckerCulture(
			SpellChecker spellChecker )
		{
			if ( spellChecker != null )
			{
				spellChecker.Culture = CultureInfo.CurrentUICulture;
			}
		}

		protected virtual bool WantSetGlobalIcon => true;

	    protected override void OnLoad(EventArgs e)
		{
			if (!DesignMode || !Zeta.VoyagerLibrary.WinForms.Base.UserControlBase.IsDesignMode(this))
			{
				if (MainForm.Current != null && WantSetGlobalIcon)
				{
					// Share an icon to make the file size smaller.
					Icon = MainForm.Current.Icon;
					/*ShowIcon = true;*/
				}

				// 2010-11-25, Uwe Keim. Experimentally.
				AutoScaleMode = AutoScaleMode.None;
			}

			base.OnLoad(e);
		}

		public static void ApplySpellCheckerCulture(
			SpellChecker spellChecker,
			string languageCode )
		{
			if ( spellChecker != null )
			{
				spellChecker.Culture = LanguageCodeDetection.MakeValidCulture(languageCode);
			}
		}

		public FormBase( IContainer container )
		{
			container.Add( this );

			InitializeComponent();
		}

		public static string BuildIDHierarchy(
			Control c )
		{
			var sb = new StringBuilder();

			while ( c != null )
			{
				if ( sb.Length > 0 )
				{
					sb.Append( '.' );
				}

				sb.Append( c.Name );
				c = c.Parent;
			}

			return sb.ToString();
		}

		public virtual void UpdateUI()
		{
		}

		public void PersistState()
		{
			WinFormsPersistanceHelper.SaveState( this );
		}

		/// <summary>
		/// Restores the state.
		/// </summary>
		/// <returns>Returns TRUE if changed, FALSE otherwise.</returns>
		public bool RestoreState()
		{
			var bounds = Bounds;
			var state = WindowState;

			WinFormsPersistanceHelper.RestoreState( this );

			return bounds != Bounds || state != WindowState;
		}

		/// <summary>
		/// Restores the state.
		/// </summary>
		/// <returns>Returns TRUE if changed, FALSE otherwise.</returns>
		public bool RestoreState( int zoom )
		{
			var bounds = Bounds;
			var state = WindowState;

			WinFormsPersistanceHelper.RestoreState(
				this,
				new RestoreInformation
				{
					SuggestZoomPercent = zoom,
					//RespectWindowRatio = false
				} );

			return bounds != Bounds || state != WindowState;
		}

		public static void SaveState(
			XtraTabControl tabControl )
		{
			PersistanceHelper.SaveValue( tabControl + @".Index", tabControl.SelectedTabPageIndex );
		}

		public static void RestoreState(
			XtraTabControl tabControl )
		{
			var index =
				ConvertHelper.ToInt32(
					PersistanceHelper.RestoreValue( tabControl + @".Index", tabControl.SelectedTabPageIndex ),
					tabControl.SelectedTabPageIndex );

			if ( index < tabControl.TabPages.Count )
			{
				tabControl.SelectedTabPageIndex = index;
			}
		}

		//public static void SaveState(
		//	SplitContainerControl splitContainer )
		//{
		//	saveState( PersistanceHelper.Storage, splitContainer );
		//}

		//public static void RestoreState(
		//	SplitContainerControl splitContainer )
		//{
		//	restoreState( PersistanceHelper.Storage, splitContainer );
		//}

		private static void restoreState(
			IPersistentPairStorage storage,
			SplitContainerControl c )
		{
			var prefix = c.Name;

			var o1 = PersistanceHelper.RestoreValue( storage, prefix + @".SplitterPosition" );
			var o2 = PersistanceHelper.RestoreValue( storage, prefix + @".RealSplitterPosition" );
			var o3 = PersistanceHelper.RestoreValue( storage, prefix + @".PercentageSplitterPosition" );
			var o4 = PersistanceHelper.RestoreValue( storage, prefix + @".PanelVisibility" );

			if ( o4!=null)
			{
				var s4 =
					ConvertHelper.ToString(
						o4,
						SplitPanelVisibility.Both.ToString());

				c.PanelVisibility =
					(SplitPanelVisibility)
					Enum.Parse(typeof (SplitPanelVisibility), s4, true);
			}

			if ( o3 != null )
			{
				// New method, saving and restoring the percentage.
				// See http://bytes.com/forum/thread616388.html.

				var percentageDistance = ConvertHelper.ToDouble( o3, CultureInfo.InvariantCulture );

				if ( c.Horizontal )
				{
					var realDistance = (int)(c.Height * (percentageDistance / 100.0));
					if ( realDistance > 0 )
					{
						c.SplitterPosition = realDistance;
					}
				}
				else
				{
					var realDistance = (int)(c.Width * (percentageDistance / 100.0));
					if ( realDistance > 0 )
					{
						c.SplitterPosition = realDistance;
					}
				}
			}
			else if ( o1 != null && o2 != null )
			{
				var realDistance = Convert.ToInt32( o2 );

				if ( c.Horizontal )
				{
					if ( c.FixedPanel == SplitFixedPanel.Panel1 ||
						c.FixedPanel == SplitFixedPanel.None )
					{
						if ( realDistance > 0 )
						{
							c.SplitterPosition = realDistance;
						}
					}
					else
					{
						Debug.Assert(
							c.FixedPanel == SplitFixedPanel.Panel2,
							@"You must set one panel inside a splitter to be fixed." );

						if ( (c.Height - realDistance) > 0 )
						{
							c.SplitterPosition = c.Height - realDistance;
						}
					}
				}
				else
				{
					if ( c.FixedPanel == SplitFixedPanel.Panel1 ||
						c.FixedPanel == SplitFixedPanel.None )
					{
						if ( realDistance > 0 )
						{
							c.SplitterPosition = realDistance;
						}
					}
					else
					{
						Debug.Assert(
							c.FixedPanel == SplitFixedPanel.Panel2,
							@"FixedPanel must be Panel2." );

						if ( (c.Width - realDistance) > 0 )
						{
							c.SplitterPosition = c.Width - realDistance;
						}
					}
				}
			}
		}

		private static void saveState(
			IPersistentPairStorage storage,
			SplitContainerControl c )
		{
			int realDistance;
			double percentageDistance;

			if (c.Horizontal)
			{
				if (c.FixedPanel == SplitFixedPanel.Panel1 ||
				    c.FixedPanel == SplitFixedPanel.None)
				{
					realDistance = c.SplitterPosition;
				}
				else
				{
					Debug.Assert(
						c.FixedPanel == SplitFixedPanel.Panel2,
						@"FixedPanel must be Panel2.");

					realDistance = c.Height - c.SplitterPosition;
				}

				percentageDistance = ((double) c.SplitterPosition/c.Height)*100.0;
			}
			else
			{
				if (c.FixedPanel == SplitFixedPanel.Panel1 ||
				    c.FixedPanel == SplitFixedPanel.None)
				{
					realDistance = c.SplitterPosition;
				}
				else
				{
					Debug.Assert(
						c.FixedPanel == SplitFixedPanel.Panel2,
						@"FixedPanel must be Panel2.");

					realDistance = c.Width - c.SplitterPosition;
				}

				percentageDistance = ((double) c.SplitterPosition/c.Width)*100.0;
			}

			// --

			var prefix = c.Name;

			if (c.SplitterPosition > 0)
			{
				PersistanceHelper.SaveValue(storage, prefix + @".SplitterPosition", c.SplitterPosition);
			}
			if (realDistance > 0)
			{
				PersistanceHelper.SaveValue(storage, prefix + @".RealSplitterPosition", realDistance);
			}
			if (percentageDistance > 0)
			{
				PersistanceHelper.SaveValue(storage, prefix + @".PercentageSplitterPosition",
				                     percentageDistance.ToString(CultureInfo.InvariantCulture));
			}

			PersistanceHelper.SaveValue(
				storage,
				prefix + @".PanelVisibility",
				c.PanelVisibility.ToString());
		}

		public static void RestoreState(RibbonControl ribbon)
		{
			var s = ConvertHelper.ToString(PersistanceHelper.RestoreValue(ribbon.Name+@".Toolbar"));

			if (!string.IsNullOrEmpty(s))
			{
				using (var ms =
					new MemoryStream(Encoding.UTF8.GetBytes(s)))
				{
					ribbon.Toolbar.RestoreLayoutFromStream(ms);
				}
			}
		}

		public static void SaveState(RibbonControl ribbon)
		{
			using (var ms = new MemoryStream())
			{
				ribbon.Toolbar.SaveLayoutToStream(ms);
				ms.Seek(0, SeekOrigin.Begin);

				string s;
				using (var sr = new StreamReader(ms, Encoding.UTF8))
				{
					s = sr.ReadToEnd();
				}

				PersistanceHelper.SaveValue(ribbon.Name + @".Toolbar", s);
			}
		}
	}
}