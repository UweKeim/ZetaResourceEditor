namespace ZetaResourceEditor.ExtendedControlsLibrary.General.Base;

using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using Skinning.CustomForm;
using System.Globalization;
using System.Xml;
using UIUpdating;
using Zeta.VoyagerLibrary.Core.Common;
using Zeta.VoyagerLibrary.Core.Tools.Storage;

/// <summary>
/// Base class for devexpress forms.
/// </summary>
public class DevExpressXtraFormBase :
	MyXtraForm,
	IUpdateUI
{
	private UpdateUIController? _uuiController;

	protected DevExpressXtraFormBase()
	{
		// Allow for capturing the F1 key.
		KeyPreview = true;
	}

	protected UpdateUIController UuiController => _uuiController ??= new();

	public virtual void DoUpdateUI(
		UpdateUIInformation information)
	{
		// Does nothing.
	}

	public void PerformUpdateUI(object? userState = null)
	{
		if (!DesignMode)
		{
			UuiController.PerformUpdateUI(this, userState);
		}
	}

	protected override void OnShown(
		EventArgs e)
	{
		base.OnShown(e);

		PerformUpdateUI();
	}

	public bool AllowF1Help { get; set; } = true;

	public static void SaveState(
		SplitContainerControl c)
	{
		saveState(PersistanceHelper.Storage, c);
	}

	public static void RestoreState(
		SplitContainerControl c)
	{
		restoreState(PersistanceHelper.Storage, c);
	}

	private static void restoreState(
		IPersistentPairStorage storage,
		SplitContainerControl c)
	{
		var prefix = c.Name;

		var o1 = PersistanceHelper.RestoreValue(storage, prefix + @".SplitterPosition");
		var o2 = PersistanceHelper.RestoreValue(storage, prefix + @".RealSplitterPosition");
		//var o3 = PersistanceHelper.RestoreValue(storage, prefix + @".PercentageSplitterPosition");
		var o4 = PersistanceHelper.RestoreValue(storage, prefix + @".PanelVisibility");

		if (o4 != null)
		{
			var s4 =
				ConvertHelper.ToString(
					o4,
					SplitPanelVisibility.Both.ToString());

			c.PanelVisibility =
				(SplitPanelVisibility)
				Enum.Parse(typeof(SplitPanelVisibility), s4, true);
		}

		/*if (o3 != null)
        {
            // New method, saving and restoring the percentage.
            // See http://bytes.com/forum/thread616388.html.

            var percentageDistance = ConvertHelper.ToDouble(o3, CultureInfo.InvariantCulture);

            if (c.Horizontal)
            {
                var realDistance = (int) (c.Width*(percentageDistance/100.0));
                if (realDistance > 0)
                {
                    c.SplitterPosition = realDistance;
                }
            }
            else
            {
                var realDistance = (int) (c.Height*(percentageDistance/100.0));
                if (realDistance > 0)
                {
                    c.SplitterPosition = realDistance;
                }
            }
        }
        else*/
		if (o1 != null && o2 != null)
		{
			var realDistance = Convert.ToInt32(o2);

			if (c.Horizontal)
			{
				if (c.FixedPanel is SplitFixedPanel.Panel1 or SplitFixedPanel.None)
				{
					if (realDistance > 0)
					{
						c.SplitterPosition = realDistance;
					}
				}
				else
				{
					if (c.FixedPanel != SplitFixedPanel.Panel2)
					{
						throw new(@"FixedPanel must be Panel2.");
					}

					if (c.Width - realDistance > 0)
					{
						c.SplitterPosition = c.Width - realDistance;
					}
				}
			}
			else
			{
				if (c.FixedPanel is SplitFixedPanel.Panel1 or SplitFixedPanel.None)
				{
					if (realDistance > 0)
					{
						c.SplitterPosition = realDistance;
					}
				}
				else
				{
					if (c.FixedPanel != SplitFixedPanel.Panel2)
					{
						throw new(@"You must set one panel inside a splitter to be fixed.");
					}

					if (c.Height - realDistance > 0)
					{
						c.SplitterPosition = c.Height - realDistance;
					}
				}
			}
		}
	}

	private static void saveState(
		IPersistentPairStorage storage,
		SplitContainerControl c)
	{
		int realDistance;
		double percentageDistance;

		if (c.Horizontal)
		{
			if (c.FixedPanel is SplitFixedPanel.Panel1 or SplitFixedPanel.None)
			{
				realDistance = c.SplitterPosition;
			}
			else
			{
				if (c.FixedPanel != SplitFixedPanel.Panel2)
				{
					throw new(@"FixedPanel must be Panel2.");
				}

				realDistance = c.Width - c.SplitterPosition;
			}

			percentageDistance = (double)c.SplitterPosition / c.Width * 100.0;
		}
		else
		{
			if (c.FixedPanel is SplitFixedPanel.Panel1 or SplitFixedPanel.None)
			{
				realDistance = c.SplitterPosition;
			}
			else
			{
				if (c.FixedPanel != SplitFixedPanel.Panel2)
				{
					throw new(@"FixedPanel must be Panel2.");
				}

				realDistance = c.Height - c.SplitterPosition;
			}

			percentageDistance = (double)c.SplitterPosition / c.Height * 100.0;
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

	protected static void SaveState(TreeList treeList)
	{
		saveState(PersistanceHelper.Storage, treeList);
	}

	public static void SaveState(GridView gridView)
	{
		saveState(PersistanceHelper.Storage, gridView);
	}

	protected static void RestoreState(TreeList treeList)
	{
		restoreState(PersistanceHelper.Storage, treeList);
	}

	public static void RestoreState(GridView gridView)
	{
		restoreState(PersistanceHelper.Storage, gridView);
	}

	protected static void SaveState(ComboBoxEdit c)
	{
		saveState(PersistanceHelper.Storage, c);
	}

	protected static void SaveState(CheckEdit c)
	{
		saveState(PersistanceHelper.Storage, c);
	}

	protected static void SaveState(TextEdit c)
	{
		saveState(PersistanceHelper.Storage, c);
	}

	protected static void RestoreState(ComboBoxEdit c)
	{
		restoreState(PersistanceHelper.Storage, c);
	}

	private static void restoreState(
		IPersistentPairStorage storage,
		ComboBoxEdit c)
	{
		var prefix = c.Name;

		var o = PersistanceHelper.RestoreValue(storage, prefix + @".SelectedIndex");
		if (o != null)
		{
			var index = ConvertHelper.ToInt32(o);

			if (index <= c.Properties.Items.Count - 1)
			{
				c.SelectedIndex = index;
			}
		}

		if (c.Properties.TextEditStyle == TextEditStyles.Standard)
		{
			c.Text = PersistanceHelper.RestoreValue(storage, prefix + @".Text") as string;
		}
	}

	protected static void RestoreState(TextEdit c)
	{
		restoreState(PersistanceHelper.Storage, c);
	}

	private static void restoreState(
		IPersistentPairStorage storage,
		TextEdit c)
	{
		var prefix = c.Name;
		c.Text = PersistanceHelper.RestoreValue(storage, prefix + @".Text") as string;
	}

	protected static void RestoreState(CheckEdit c)
	{
		restoreState(PersistanceHelper.Storage, c);
	}

	private static void restoreState(
		IPersistentPairStorage storage,
		CheckEdit c)
	{
		var prefix = c.Name;

		var o = PersistanceHelper.RestoreValue(storage, prefix + @".Checked");
		if (o != null)
		{
			var index = ConvertHelper.ToBoolean(o);
			c.Checked = index;
		}
	}

	private static void saveState(
		IPersistentPairStorage storage,
		ComboBoxEdit c)
	{
		var prefix = c.Name;

		PersistanceHelper.SaveValue(
			storage,
			prefix + @".SelectedIndex",
			c.SelectedIndex);

		if (c.Properties.TextEditStyle == TextEditStyles.Standard)
		{
			PersistanceHelper.SaveValue(
				storage,
				prefix + @".Text",
				c.Text);
		}
	}

	private static void saveState(
		IPersistentPairStorage storage,
		CheckEdit c)
	{
		var prefix = c.Name;

		PersistanceHelper.SaveValue(
			storage,
			prefix + @".Checked",
			c.Checked);
	}

	private static void saveState(
		IPersistentPairStorage storage,
		TextEdit c)
	{
		var prefix = c.Name;

		PersistanceHelper.SaveValue(
			storage,
			prefix + @".Text",
			c.Text);
	}

	private static void saveState(
		IPersistentPairStorage storage,
		TreeList c)
	{
		var prefix = c.Name;

		using var tfc = new ZetaTemporaryFileCreator();
		c.SaveLayoutToXml(
			tfc.FilePath,
			new OptionsLayoutTreeList
			{
				AddNewColumns = false,
				RemoveOldColumns = true,
				StoreAppearance = false
			});

		PersistanceHelper.SaveValue(
			storage,
			prefix + @".TreeList",
			tfc.FileContentString);
	}

	private static void restoreState(
		IPersistentPairStorage storage,
		TreeList c)
	{
		var prefix = c.Name;

		var xml =
			ConvertHelper.ToString(
				PersistanceHelper.RestoreValue(storage, prefix + @".TreeList") ?? string.Empty);

		if (!string.IsNullOrEmpty(xml))
		{
			// Remove unwanted serialized elements.
			xml = removeNodes(
				xml,
				new[]
				{
					@"//property[@name='OptionsBehavior']",
					@"//property[@name='OptionsMenu']",
					@"//property[@name='OptionsSelection']",
					@"//property[@name='OptionsView']"
				});

			using var tfc = new ZetaTemporaryFileCreator(xml);
			c.RestoreLayoutFromXml(
				tfc.FilePath,
				new OptionsLayoutTreeList
				{
					AddNewColumns = false,
					RemoveOldColumns = true,
					StoreAppearance = false
				});
		}
	}

	private static void saveState(
		IPersistentPairStorage storage,
		GridView c)
	{
		var prefix = c.Name;

		using var tfc = new ZetaTemporaryFileCreator();
		c.SaveLayoutToXml(
			tfc.FilePath,
			new OptionsLayoutGrid
			{
				StoreAllOptions = false,
				StoreDataSettings = true,
				StoreVisualOptions = false,
				StoreAppearance = false
			});

		PersistanceHelper.SaveValue(
			storage,
			prefix + @".GridView",
			tfc.FileContentString);
	}

	private static void restoreState(
		IPersistentPairStorage storage,
		GridView c)
	{
		var prefix = c.Name;

		var xml =
			ConvertHelper.ToString(
				PersistanceHelper.RestoreValue(storage, prefix + @".GridView") ?? string.Empty);

		if (!string.IsNullOrEmpty(xml))
		{
			using var tfc = new ZetaTemporaryFileCreator(xml);
			c.RestoreLayoutFromXml(
				tfc.FilePath,
				new OptionsLayoutGrid
				{
					StoreAllOptions = false,
					StoreDataSettings = true,
					StoreVisualOptions = false,
					StoreAppearance = false
				});
		}
	}

	private static string removeNodes(
		string xml,
		IEnumerable<string> xpaths)
	{
		var doc = new XmlDocument();
		doc.LoadXml(xml);

		foreach (var xpath in xpaths)
		{
			if (!string.IsNullOrEmpty(xpath))
			{
				var nodes = doc.SelectNodes(xpath);
				if (nodes != null)
				{
					foreach (XmlNode xmlNode in nodes)
					{
						xmlNode.ParentNode?.RemoveChild(xmlNode);
					}
				}
			}
		}

		return doc.OuterXml;
	}
}