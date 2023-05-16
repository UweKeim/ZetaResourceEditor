namespace ZetaResourceEditor.UI.Main.RightContent
{
	using System.Data;

	partial class ResourceEditorUserControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new Container();
			ComponentResourceManager resources = new ComponentResourceManager(typeof(ResourceEditorUserControl));
			resourceEditorUserControlMainSplitContainer = new SplitContainerControl();
			tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
			tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
			statusPictureBox = new PictureBox();
			fileNameTextEdit = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			mainDataGrid = new DevExpress.XtraGrid.GridControl();
			mainGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			barManager = new BarManager(components);
			barDockControlTop = new BarDockControl();
			barDockControlBottom = new BarDockControl();
			barDockControlLeft = new BarDockControl();
			barDockControlRight = new BarDockControl();
			buttonAddTag = new BarButtonItem();
			buttonEditTag = new BarButtonItem();
			buttonDeleteTag = new BarButtonItem();
			buttonSelectAllInGrid = new BarButtonItem();
			buttonCopySelectedRowsToClipboard = new BarButtonItem();
			buttonDeleteRowContents = new BarButtonItem();
			buttonDeleteSelectedContents = new BarButtonItem();
			tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
			tabControl1 = new ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabControl();
			xtraTabPage1 = new ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage();
			updateInGridButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			labelControl1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			optionsPopupMenu = new PopupMenu(components);
			updateDetailsTimer = new System.Windows.Forms.Timer(components);
			((ISupportInitialize)resourceEditorUserControlMainSplitContainer).BeginInit();
			((ISupportInitialize)resourceEditorUserControlMainSplitContainer.Panel1).BeginInit();
			resourceEditorUserControlMainSplitContainer.Panel1.SuspendLayout();
			((ISupportInitialize)resourceEditorUserControlMainSplitContainer.Panel2).BeginInit();
			resourceEditorUserControlMainSplitContainer.Panel2.SuspendLayout();
			resourceEditorUserControlMainSplitContainer.SuspendLayout();
			((ISupportInitialize)tablePanel1).BeginInit();
			tablePanel1.SuspendLayout();
			((ISupportInitialize)tablePanel3).BeginInit();
			tablePanel3.SuspendLayout();
			((ISupportInitialize)statusPictureBox).BeginInit();
			((ISupportInitialize)mainDataGrid).BeginInit();
			((ISupportInitialize)mainGridView).BeginInit();
			((ISupportInitialize)barManager).BeginInit();
			((ISupportInitialize)tablePanel2).BeginInit();
			tablePanel2.SuspendLayout();
			((ISupportInitialize)tabControl1).BeginInit();
			tabControl1.SuspendLayout();
			((ISupportInitialize)optionsPopupMenu).BeginInit();
			SuspendLayout();
			// 
			// resourceEditorUserControlMainSplitContainer
			// 
			resourceEditorUserControlMainSplitContainer.Dock = DockStyle.Fill;
			resourceEditorUserControlMainSplitContainer.FixedPanel = SplitFixedPanel.Panel2;
			resourceEditorUserControlMainSplitContainer.Horizontal = false;
			resourceEditorUserControlMainSplitContainer.Location = new Point(0, 0);
			resourceEditorUserControlMainSplitContainer.Margin = new Padding(0);
			resourceEditorUserControlMainSplitContainer.Name = "resourceEditorUserControlMainSplitContainer";
			// 
			// resourceEditorUserControlMainSplitContainer.Panel1
			// 
			resourceEditorUserControlMainSplitContainer.Panel1.AppearanceCaption.Image = (Image)resources.GetObject("resourceEditorUserControlMainSplitContainer.Panel1.AppearanceCaption.Image");
			resourceEditorUserControlMainSplitContainer.Panel1.AppearanceCaption.Options.UseImage = true;
			resourceEditorUserControlMainSplitContainer.Panel1.BorderStyle = BorderStyles.Default;
			resourceEditorUserControlMainSplitContainer.Panel1.Controls.Add(tablePanel1);
			resourceEditorUserControlMainSplitContainer.Panel1.Padding = new Padding(6);
			resourceEditorUserControlMainSplitContainer.Panel1.Text = "Resources grid";
			// 
			// resourceEditorUserControlMainSplitContainer.Panel2
			// 
			resourceEditorUserControlMainSplitContainer.Panel2.BorderStyle = BorderStyles.Default;
			resourceEditorUserControlMainSplitContainer.Panel2.Controls.Add(tablePanel2);
			resourceEditorUserControlMainSplitContainer.Panel2.MinSize = 200;
			resourceEditorUserControlMainSplitContainer.Panel2.Padding = new Padding(6);
			resourceEditorUserControlMainSplitContainer.Panel2.Text = "Details view";
			resourceEditorUserControlMainSplitContainer.Size = new Size(404, 580);
			resourceEditorUserControlMainSplitContainer.SplitterPosition = 188;
			resourceEditorUserControlMainSplitContainer.TabIndex = 0;
			// 
			// tablePanel1
			// 
			tablePanel1.AutoSize = true;
			tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel1.Controls.Add(tablePanel3);
			tablePanel1.Controls.Add(mainDataGrid);
			tablePanel1.Dock = DockStyle.Fill;
			tablePanel1.Location = new Point(6, 6);
			tablePanel1.Margin = new Padding(0);
			tablePanel1.Name = "tablePanel1";
			tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 28F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel1.Size = new Size(388, 354);
			tablePanel1.TabIndex = 0;
			// 
			// tablePanel3
			// 
			tablePanel3.AutoSize = true;
			tablePanel1.SetColumn(tablePanel3, 0);
			tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F) });
			tablePanel3.Controls.Add(statusPictureBox);
			tablePanel3.Controls.Add(fileNameTextEdit);
			tablePanel3.Dock = DockStyle.Fill;
			tablePanel3.Location = new Point(0, 0);
			tablePanel3.Margin = new Padding(0, 0, 0, 9);
			tablePanel3.Name = "tablePanel3";
			tablePanel1.SetRow(tablePanel3, 0);
			tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 30F) });
			tablePanel3.Size = new Size(388, 22);
			tablePanel3.TabIndex = 6;
			// 
			// statusPictureBox
			// 
			tablePanel3.SetColumn(statusPictureBox, 0);
			statusPictureBox.Image = (Image)resources.GetObject("statusPictureBox.Image");
			statusPictureBox.Location = new Point(3, 3);
			statusPictureBox.MinimumSize = new Size(16, 16);
			statusPictureBox.Name = "statusPictureBox";
			tablePanel3.SetRow(statusPictureBox, 0);
			statusPictureBox.Size = new Size(16, 16);
			statusPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
			statusPictureBox.TabIndex = 1;
			statusPictureBox.TabStop = false;
			// 
			// fileNameTextEdit
			// 
			fileNameTextEdit.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			fileNameTextEdit.Appearance.Options.UseFont = true;
			fileNameTextEdit.AutoSizeMode = LabelAutoSizeMode.Vertical;
			tablePanel3.SetColumn(fileNameTextEdit, 1);
			fileNameTextEdit.Dock = DockStyle.Fill;
			fileNameTextEdit.Location = new Point(25, 0);
			fileNameTextEdit.Margin = new Padding(3, 0, 0, 0);
			fileNameTextEdit.Name = "fileNameTextEdit";
			tablePanel3.SetRow(fileNameTextEdit, 0);
			fileNameTextEdit.Size = new Size(363, 22);
			fileNameTextEdit.TabIndex = 2;
			fileNameTextEdit.Text = "<TODO>";
			// 
			// mainDataGrid
			// 
			tablePanel1.SetColumn(mainDataGrid, 0);
			mainDataGrid.Dock = DockStyle.Fill;
			mainDataGrid.Location = new Point(0, 31);
			mainDataGrid.MainView = mainGridView;
			mainDataGrid.Margin = new Padding(0);
			mainDataGrid.MenuManager = barManager;
			mainDataGrid.Name = "mainDataGrid";
			tablePanel1.SetRow(mainDataGrid, 1);
			mainDataGrid.Size = new Size(388, 323);
			mainDataGrid.TabIndex = 1;
			mainDataGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { mainGridView });
			// 
			// mainGridView
			// 
			mainGridView.GridControl = mainDataGrid;
			mainGridView.Name = "mainGridView";
			mainGridView.OptionsBehavior.AllowAddRows = DefaultBoolean.False;
			mainGridView.OptionsBehavior.AllowDeleteRows = DefaultBoolean.False;
			mainGridView.OptionsCustomization.AllowColumnMoving = false;
			mainGridView.OptionsCustomization.AllowGroup = false;
			mainGridView.OptionsCustomization.AllowQuickHideColumns = false;
			mainGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
			mainGridView.OptionsSelection.EnableAppearanceHideSelection = false;
			mainGridView.OptionsSelection.MultiSelect = true;
			mainGridView.OptionsView.RowAutoHeight = true;
			mainGridView.OptionsView.ShowGroupPanel = false;
			mainGridView.OptionsView.ShowIndicator = false;
			mainGridView.RowCellStyle += mainDataView_RowCellStyle;
			mainGridView.PopupMenuShowing += mainGridView_PopupMenuShowing;
			mainGridView.SelectionChanged += mainDataView_SelectionChanged;
			mainGridView.ShownEditor += mainGridView_ShownEditor;
			mainGridView.EndSorting += mainGridView_EndSorting;
			mainGridView.FocusedRowChanged += mainDataView_FocusedRowChanged;
			mainGridView.FocusedColumnChanged += mainDataView_FocusedColumnChanged;
			mainGridView.CellValueChanged += mainDataView_CellValueChanged;
			mainGridView.CustomRowFilter += mainGridView_CustomRowFilter;
			mainGridView.MouseUp += mainGridView_MouseUp;
			// 
			// barManager
			// 
			barManager.DockControls.Add(barDockControlTop);
			barManager.DockControls.Add(barDockControlBottom);
			barManager.DockControls.Add(barDockControlLeft);
			barManager.DockControls.Add(barDockControlRight);
			barManager.Form = this;
			barManager.Items.AddRange(new BarItem[] { buttonAddTag, buttonEditTag, buttonDeleteTag, buttonSelectAllInGrid, buttonCopySelectedRowsToClipboard, buttonDeleteRowContents, buttonDeleteSelectedContents });
			barManager.MaxItemId = 10;
			// 
			// barDockControlTop
			// 
			barDockControlTop.CausesValidation = false;
			barDockControlTop.Dock = DockStyle.Top;
			barDockControlTop.Location = new Point(0, 0);
			barDockControlTop.Manager = barManager;
			barDockControlTop.Size = new Size(404, 0);
			// 
			// barDockControlBottom
			// 
			barDockControlBottom.CausesValidation = false;
			barDockControlBottom.Dock = DockStyle.Bottom;
			barDockControlBottom.Location = new Point(0, 580);
			barDockControlBottom.Manager = barManager;
			barDockControlBottom.Size = new Size(404, 0);
			// 
			// barDockControlLeft
			// 
			barDockControlLeft.CausesValidation = false;
			barDockControlLeft.Dock = DockStyle.Left;
			barDockControlLeft.Location = new Point(0, 0);
			barDockControlLeft.Manager = barManager;
			barDockControlLeft.Size = new Size(0, 580);
			// 
			// barDockControlRight
			// 
			barDockControlRight.CausesValidation = false;
			barDockControlRight.Dock = DockStyle.Right;
			barDockControlRight.Location = new Point(404, 0);
			barDockControlRight.Manager = barManager;
			barDockControlRight.Size = new Size(0, 580);
			// 
			// buttonAddTag
			// 
			buttonAddTag.Caption = "Add new tag";
			buttonAddTag.Id = 3;
			buttonAddTag.ImageOptions.Image = (Image)resources.GetObject("buttonAddTag.ImageOptions.Image");
			buttonAddTag.Name = "buttonAddTag";
			buttonAddTag.ItemClick += buttonAddTag_ItemClick;
			// 
			// buttonEditTag
			// 
			buttonEditTag.Caption = "Edit tag";
			buttonEditTag.Id = 4;
			buttonEditTag.ImageOptions.Image = (Image)resources.GetObject("buttonEditTag.ImageOptions.Image");
			buttonEditTag.Name = "buttonEditTag";
			buttonEditTag.ItemClick += buttonEditTag_ItemClick;
			// 
			// buttonDeleteTag
			// 
			buttonDeleteTag.Caption = "Delete tag";
			buttonDeleteTag.Id = 5;
			buttonDeleteTag.ImageOptions.Image = (Image)resources.GetObject("buttonDeleteTag.ImageOptions.Image");
			buttonDeleteTag.Name = "buttonDeleteTag";
			buttonDeleteTag.ItemClick += buttonDeleteTag_ItemClick;
			// 
			// buttonSelectAllInGrid
			// 
			buttonSelectAllInGrid.Caption = "Select all rows";
			buttonSelectAllInGrid.Id = 6;
			buttonSelectAllInGrid.ImageOptions.Image = (Image)resources.GetObject("buttonSelectAllInGrid.ImageOptions.Image");
			buttonSelectAllInGrid.Name = "buttonSelectAllInGrid";
			buttonSelectAllInGrid.ItemClick += buttonSelectAllInGrid_ItemClick;
			// 
			// buttonCopySelectedRowsToClipboard
			// 
			buttonCopySelectedRowsToClipboard.Caption = "Copy selected rows to clipboard";
			buttonCopySelectedRowsToClipboard.Id = 7;
			buttonCopySelectedRowsToClipboard.ImageOptions.Image = (Image)resources.GetObject("buttonCopySelectedRowsToClipboard.ImageOptions.Image");
			buttonCopySelectedRowsToClipboard.Name = "buttonCopySelectedRowsToClipboard";
			buttonCopySelectedRowsToClipboard.ItemClick += buttonCopySelectedRowsToClipboard_ItemClick;
			// 
			// buttonDeleteRowContents
			// 
			buttonDeleteRowContents.Caption = "Delete row contents";
			buttonDeleteRowContents.Id = 8;
			buttonDeleteRowContents.ImageOptions.Image = (Image)resources.GetObject("buttonDeleteRowContents.ImageOptions.Image");
			buttonDeleteRowContents.Name = "buttonDeleteRowContents";
			buttonDeleteRowContents.ItemClick += buttonDeleteRowContents_ItemClick;
			// 
			// buttonDeleteSelectedContents
			// 
			buttonDeleteSelectedContents.Caption = "Delete selected contents";
			buttonDeleteSelectedContents.Id = 9;
			buttonDeleteSelectedContents.Name = "buttonDeleteSelectedContents";
			// 
			// tablePanel2
			// 
			tablePanel2.AutoSize = true;
			tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 116F) });
			tablePanel2.Controls.Add(tabControl1);
			tablePanel2.Controls.Add(updateInGridButton);
			tablePanel2.Controls.Add(labelControl1);
			tablePanel2.Dock = DockStyle.Fill;
			tablePanel2.Location = new Point(6, 6);
			tablePanel2.Margin = new Padding(0);
			tablePanel2.Name = "tablePanel2";
			tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel2.Size = new Size(388, 184);
			tablePanel2.TabIndex = 5;
			// 
			// tabControl1
			// 
			tabControl1.AppearancePage.Header.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			tabControl1.AppearancePage.Header.Options.UseFont = true;
			tablePanel2.SetColumn(tabControl1, 0);
			tablePanel2.SetColumnSpan(tabControl1, 2);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.Location = new Point(0, 26);
			tabControl1.Margin = new Padding(0, 0, 0, 9);
			tabControl1.Name = "tabControl1";
			tablePanel2.SetRow(tabControl1, 1);
			tabControl1.SelectedTabPage = xtraTabPage1;
			tabControl1.Size = new Size(388, 121);
			tabControl1.TabIndex = 1;
			tabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1 });
			// 
			// xtraTabPage1
			// 
			xtraTabPage1.Name = "xtraTabPage1";
			xtraTabPage1.Size = new Size(386, 92);
			xtraTabPage1.Text = "<L>";
			// 
			// updateInGridButton
			// 
			updateInGridButton.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			updateInGridButton.Appearance.Options.UseFont = true;
			tablePanel2.SetColumn(updateInGridButton, 1);
			updateInGridButton.Dock = DockStyle.Fill;
			updateInGridButton.Location = new Point(272, 156);
			updateInGridButton.Margin = new Padding(0);
			updateInGridButton.Name = "updateInGridButton";
			tablePanel2.SetRow(updateInGridButton, 2);
			updateInGridButton.Size = new Size(116, 28);
			updateInGridButton.TabIndex = 2;
			updateInGridButton.Text = "&Update in grid";
			updateInGridButton.Click += updateInGridButton_Click;
			// 
			// labelControl1
			// 
			labelControl1.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelControl1.Appearance.Options.UseFont = true;
			labelControl1.AutoSizeMode = LabelAutoSizeMode.Vertical;
			tablePanel2.SetColumn(labelControl1, 0);
			tablePanel2.SetColumnSpan(labelControl1, 2);
			labelControl1.Dock = DockStyle.Fill;
			labelControl1.Location = new Point(0, 0);
			labelControl1.Margin = new Padding(0, 0, 0, 9);
			labelControl1.Name = "labelControl1";
			tablePanel2.SetRow(labelControl1, 0);
			labelControl1.Size = new Size(388, 17);
			labelControl1.TabIndex = 3;
			labelControl1.Text = "<TODO>";
			// 
			// optionsPopupMenu
			// 
			optionsPopupMenu.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(buttonAddTag), new LinkPersistInfo(buttonDeleteRowContents), new LinkPersistInfo(buttonDeleteTag), new LinkPersistInfo(buttonEditTag, true), new LinkPersistInfo(buttonSelectAllInGrid, true), new LinkPersistInfo(buttonCopySelectedRowsToClipboard) });
			optionsPopupMenu.Manager = barManager;
			optionsPopupMenu.Name = "optionsPopupMenu";
			optionsPopupMenu.BeforePopup += optionsPopupMenu_BeforePopup;
			// 
			// updateDetailsTimer
			// 
			updateDetailsTimer.Interval = 200;
			updateDetailsTimer.Tick += updateDetailsTimer_Tick;
			// 
			// ResourceEditorUserControl
			// 
			Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(resourceEditorUserControlMainSplitContainer);
			Controls.Add(barDockControlLeft);
			Controls.Add(barDockControlRight);
			Controls.Add(barDockControlBottom);
			Controls.Add(barDockControlTop);
			Name = "ResourceEditorUserControl";
			Size = new Size(404, 580);
			Load += resourceEditorUserControlNew_Load;
			SizeChanged += resourceEditorUserControlNew_SizeChanged;
			((ISupportInitialize)resourceEditorUserControlMainSplitContainer.Panel1).EndInit();
			resourceEditorUserControlMainSplitContainer.Panel1.ResumeLayout(false);
			resourceEditorUserControlMainSplitContainer.Panel1.PerformLayout();
			((ISupportInitialize)resourceEditorUserControlMainSplitContainer.Panel2).EndInit();
			resourceEditorUserControlMainSplitContainer.Panel2.ResumeLayout(false);
			resourceEditorUserControlMainSplitContainer.Panel2.PerformLayout();
			((ISupportInitialize)resourceEditorUserControlMainSplitContainer).EndInit();
			resourceEditorUserControlMainSplitContainer.ResumeLayout(false);
			((ISupportInitialize)tablePanel1).EndInit();
			tablePanel1.ResumeLayout(false);
			tablePanel1.PerformLayout();
			((ISupportInitialize)tablePanel3).EndInit();
			tablePanel3.ResumeLayout(false);
			tablePanel3.PerformLayout();
			((ISupportInitialize)statusPictureBox).EndInit();
			((ISupportInitialize)mainDataGrid).EndInit();
			((ISupportInitialize)mainGridView).EndInit();
			((ISupportInitialize)barManager).EndInit();
			((ISupportInitialize)tablePanel2).EndInit();
			tablePanel2.ResumeLayout(false);
			tablePanel2.PerformLayout();
			((ISupportInitialize)tabControl1).EndInit();
			tabControl1.ResumeLayout(false);
			((ISupportInitialize)optionsPopupMenu).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraEditors.SplitContainerControl resourceEditorUserControlMainSplitContainer;
		private DevExpress.XtraBars.PopupMenu optionsPopupMenu;
		private DevExpress.XtraBars.BarManager barManager;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraGrid.GridControl mainDataGrid;
		private DevExpress.XtraGrid.Views.Grid.GridView mainGridView;
		private ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabControl tabControl1;
		private ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage xtraTabPage1;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton updateInGridButton;
		private DevExpress.XtraBars.BarButtonItem buttonAddTag;
		private DevExpress.XtraBars.BarButtonItem buttonEditTag;
		private DevExpress.XtraBars.BarButtonItem buttonDeleteTag;
		private System.Windows.Forms.Timer updateDetailsTimer;
		private System.Windows.Forms.PictureBox statusPictureBox;
		private DevExpress.XtraBars.BarButtonItem buttonSelectAllInGrid;
		private DevExpress.XtraBars.BarButtonItem buttonCopySelectedRowsToClipboard;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl fileNameTextEdit;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl1;
		private DevExpress.XtraBars.BarButtonItem buttonDeleteRowContents;
		private DevExpress.XtraBars.BarButtonItem buttonDeleteSelectedContents;
		private DevExpress.Utils.Layout.TablePanel tablePanel1;
		private DevExpress.Utils.Layout.TablePanel tablePanel2;
		private DevExpress.Utils.Layout.TablePanel tablePanel3;
	}
}
