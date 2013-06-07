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
		protected override void Dispose( bool disposing )
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResourceEditorUserControl));
			this.resourceEditorUserControlMainSplitContainer = new DevExpress.XtraEditors.SplitContainerControl();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.mainDataGrid = new DevExpress.XtraGrid.GridControl();
			this.mainGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.barManager = new DevExpress.XtraBars.BarManager(this.components);
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.popupImageCollection = new DevExpress.Utils.ImageCollection(this.components);
			this.buttonAddTag = new DevExpress.XtraBars.BarButtonItem();
			this.buttonEditTag = new DevExpress.XtraBars.BarButtonItem();
			this.buttonDeleteTag = new DevExpress.XtraBars.BarButtonItem();
			this.buttonSelectAllInGrid = new DevExpress.XtraBars.BarButtonItem();
			this.buttonCopySelectedRowsToClipboard = new DevExpress.XtraBars.BarButtonItem();
			this.buttonDeleteRowContents = new DevExpress.XtraBars.BarButtonItem();
			this.buttonDeleteSelectedContents = new DevExpress.XtraBars.BarButtonItem();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.fileNameTextEdit = new DevExpress.XtraEditors.LabelControl();
			this.statusPictureBox = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
			this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
			this.updateInGridButton = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.optionsPopupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
			this.stateImageList = new DevExpress.Utils.ImageCollection(this.components);
			this.treeImageList = new DevExpress.Utils.ImageCollection(this.components);
			this.updateDetailsTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.resourceEditorUserControlMainSplitContainer)).BeginInit();
			this.resourceEditorUserControlMainSplitContainer.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popupImageCollection)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.statusPictureBox)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
			this.tabControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.optionsPopupMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stateImageList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.treeImageList)).BeginInit();
			this.SuspendLayout();
			// 
			// resourceEditorUserControlMainSplitContainer
			// 
			resources.ApplyResources(this.resourceEditorUserControlMainSplitContainer, "resourceEditorUserControlMainSplitContainer");
			this.resourceEditorUserControlMainSplitContainer.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
			this.resourceEditorUserControlMainSplitContainer.Horizontal = false;
			this.resourceEditorUserControlMainSplitContainer.Name = "resourceEditorUserControlMainSplitContainer";
			this.resourceEditorUserControlMainSplitContainer.Panel1.AppearanceCaption.Image = ((System.Drawing.Image)(resources.GetObject("resourceEditorUserControlMainSplitContainer.Panel1.AppearanceCaption.Image")));
			this.resourceEditorUserControlMainSplitContainer.Panel1.AppearanceCaption.Options.UseImage = true;
			this.resourceEditorUserControlMainSplitContainer.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
			this.resourceEditorUserControlMainSplitContainer.Panel1.Controls.Add(this.tableLayoutPanel1);
			resources.ApplyResources(this.resourceEditorUserControlMainSplitContainer.Panel1, "resourceEditorUserControlMainSplitContainer.Panel1");
			this.resourceEditorUserControlMainSplitContainer.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
			this.resourceEditorUserControlMainSplitContainer.Panel2.Controls.Add(this.tableLayoutPanel2);
			this.resourceEditorUserControlMainSplitContainer.Panel2.MinSize = 200;
			resources.ApplyResources(this.resourceEditorUserControlMainSplitContainer.Panel2, "resourceEditorUserControlMainSplitContainer.Panel2");
			this.resourceEditorUserControlMainSplitContainer.SplitterPosition = 188;
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.mainDataGrid, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// mainDataGrid
			// 
			resources.ApplyResources(this.mainDataGrid, "mainDataGrid");
			this.mainDataGrid.MainView = this.mainGridView;
			this.mainDataGrid.MenuManager = this.barManager;
			this.mainDataGrid.Name = "mainDataGrid";
			this.mainDataGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.mainGridView});
			// 
			// mainGridView
			// 
			this.mainGridView.GridControl = this.mainDataGrid;
			this.mainGridView.Name = "mainGridView";
			this.mainGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.mainGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.mainGridView.OptionsCustomization.AllowColumnMoving = false;
			this.mainGridView.OptionsCustomization.AllowGroup = false;
			this.mainGridView.OptionsCustomization.AllowQuickHideColumns = false;
			this.mainGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.mainGridView.OptionsSelection.EnableAppearanceHideSelection = false;
			this.mainGridView.OptionsSelection.MultiSelect = true;
			this.mainGridView.OptionsView.EnableAppearanceEvenRow = true;
			this.mainGridView.OptionsView.RowAutoHeight = true;
			this.mainGridView.OptionsView.ShowGroupPanel = false;
			this.mainGridView.OptionsView.ShowIndicator = false;
			this.mainGridView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.mainDataView_RowCellStyle);
			this.mainGridView.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.mainGridView_PopupMenuShowing);
			this.mainGridView.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.mainDataView_SelectionChanged);
			this.mainGridView.ShownEditor += new System.EventHandler(this.mainGridView_ShownEditor);
			this.mainGridView.EndSorting += new System.EventHandler(this.mainGridView_EndSorting);
			this.mainGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.mainDataView_FocusedRowChanged);
			this.mainGridView.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.mainDataView_FocusedColumnChanged);
			this.mainGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.mainDataView_CellValueChanged);
			this.mainGridView.CustomRowFilter += new DevExpress.XtraGrid.Views.Base.RowFilterEventHandler(this.mainGridView_CustomRowFilter);
			this.mainGridView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainGridView_MouseUp);
			// 
			// barManager
			// 
			this.barManager.DockControls.Add(this.barDockControlTop);
			this.barManager.DockControls.Add(this.barDockControlBottom);
			this.barManager.DockControls.Add(this.barDockControlLeft);
			this.barManager.DockControls.Add(this.barDockControlRight);
			this.barManager.Form = this;
			this.barManager.Images = this.popupImageCollection;
			this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.buttonAddTag,
            this.buttonEditTag,
            this.buttonDeleteTag,
            this.buttonSelectAllInGrid,
            this.buttonCopySelectedRowsToClipboard,
            this.buttonDeleteRowContents,
            this.buttonDeleteSelectedContents});
			this.barManager.MaxItemId = 10;
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			resources.ApplyResources(this.barDockControlTop, "barDockControlTop");
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			resources.ApplyResources(this.barDockControlBottom, "barDockControlBottom");
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			resources.ApplyResources(this.barDockControlLeft, "barDockControlLeft");
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			resources.ApplyResources(this.barDockControlRight, "barDockControlRight");
			// 
			// popupImageCollection
			// 
			this.popupImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("popupImageCollection.ImageStream")));
			this.popupImageCollection.Images.SetKeyName(0, "table_new.png");
			this.popupImageCollection.Images.SetKeyName(1, "table_edit.png");
			this.popupImageCollection.Images.SetKeyName(2, "table_delete.png");
			// 
			// buttonAddTag
			// 
			resources.ApplyResources(this.buttonAddTag, "buttonAddTag");
			this.buttonAddTag.Id = 3;
			this.buttonAddTag.ImageIndex = 0;
			this.buttonAddTag.Name = "buttonAddTag";
			this.buttonAddTag.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonAddTag_ItemClick);
			// 
			// buttonEditTag
			// 
			resources.ApplyResources(this.buttonEditTag, "buttonEditTag");
			this.buttonEditTag.Id = 4;
			this.buttonEditTag.ImageIndex = 1;
			this.buttonEditTag.Name = "buttonEditTag";
			this.buttonEditTag.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonEditTag_ItemClick);
			// 
			// buttonDeleteTag
			// 
			resources.ApplyResources(this.buttonDeleteTag, "buttonDeleteTag");
			this.buttonDeleteTag.Id = 5;
			this.buttonDeleteTag.ImageIndex = 2;
			this.buttonDeleteTag.Name = "buttonDeleteTag";
			this.buttonDeleteTag.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonDeleteTag_ItemClick);
			// 
			// buttonSelectAllInGrid
			// 
			resources.ApplyResources(this.buttonSelectAllInGrid, "buttonSelectAllInGrid");
			this.buttonSelectAllInGrid.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonSelectAllInGrid.Glyph")));
			this.buttonSelectAllInGrid.Id = 6;
			this.buttonSelectAllInGrid.Name = "buttonSelectAllInGrid";
			this.buttonSelectAllInGrid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonSelectAllInGrid_ItemClick);
			// 
			// buttonCopySelectedRowsToClipboard
			// 
			resources.ApplyResources(this.buttonCopySelectedRowsToClipboard, "buttonCopySelectedRowsToClipboard");
			this.buttonCopySelectedRowsToClipboard.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonCopySelectedRowsToClipboard.Glyph")));
			this.buttonCopySelectedRowsToClipboard.Id = 7;
			this.buttonCopySelectedRowsToClipboard.Name = "buttonCopySelectedRowsToClipboard";
			this.buttonCopySelectedRowsToClipboard.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonCopySelectedRowsToClipboard_ItemClick);
			// 
			// buttonDeleteRowContents
			// 
			resources.ApplyResources(this.buttonDeleteRowContents, "buttonDeleteRowContents");
			this.buttonDeleteRowContents.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonDeleteRowContents.Glyph")));
			this.buttonDeleteRowContents.Id = 8;
			this.buttonDeleteRowContents.Name = "buttonDeleteRowContents";
			this.buttonDeleteRowContents.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonDeleteRowContents_ItemClick);
			// 
			// buttonDeleteSelectedContents
			// 
			resources.ApplyResources(this.buttonDeleteSelectedContents, "buttonDeleteSelectedContents");
			this.buttonDeleteSelectedContents.Id = 9;
			this.buttonDeleteSelectedContents.Name = "buttonDeleteSelectedContents";
			// 
			// panelControl1
			// 
			this.panelControl1.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("panelControl1.Appearance.BackColor")));
			this.panelControl1.Appearance.Options.UseBackColor = true;
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.fileNameTextEdit);
			this.panelControl1.Controls.Add(this.statusPictureBox);
			resources.ApplyResources(this.panelControl1, "panelControl1");
			this.panelControl1.Name = "panelControl1";
			// 
			// fileNameTextEdit
			// 
			resources.ApplyResources(this.fileNameTextEdit, "fileNameTextEdit");
			this.fileNameTextEdit.Name = "fileNameTextEdit";
			// 
			// statusPictureBox
			// 
			resources.ApplyResources(this.statusPictureBox, "statusPictureBox");
			this.statusPictureBox.Name = "statusPictureBox";
			this.statusPictureBox.TabStop = false;
			// 
			// tableLayoutPanel2
			// 
			resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
			this.tableLayoutPanel2.Controls.Add(this.tabControl1, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.updateInGridButton, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.labelControl1, 0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			// 
			// tabControl1
			// 
			resources.ApplyResources(this.tabControl1, "tabControl1");
			this.tabControl1.Images = this.imageCollection1;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedTabPage = this.xtraTabPage1;
			this.tabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
			// 
			// imageCollection1
			// 
			this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
			this.imageCollection1.Images.SetKeyName(0, "document.png");
			this.imageCollection1.Images.SetKeyName(1, "note.png");
			// 
			// xtraTabPage1
			// 
			this.xtraTabPage1.Name = "xtraTabPage1";
			resources.ApplyResources(this.xtraTabPage1, "xtraTabPage1");
			// 
			// updateInGridButton
			// 
			resources.ApplyResources(this.updateInGridButton, "updateInGridButton");
			this.updateInGridButton.Image = ((System.Drawing.Image)(resources.GetObject("updateInGridButton.Image")));
			this.updateInGridButton.Name = "updateInGridButton";
			this.updateInGridButton.Click += new System.EventHandler(this.updateInGridButton_Click);
			// 
			// labelControl1
			// 
			resources.ApplyResources(this.labelControl1, "labelControl1");
			this.labelControl1.Name = "labelControl1";
			// 
			// optionsPopupMenu
			// 
			this.optionsPopupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonAddTag),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonDeleteRowContents),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonDeleteTag),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonEditTag, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonSelectAllInGrid, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonCopySelectedRowsToClipboard)});
			this.optionsPopupMenu.Manager = this.barManager;
			this.optionsPopupMenu.Name = "optionsPopupMenu";
			this.optionsPopupMenu.BeforePopup += new System.ComponentModel.CancelEventHandler(this.optionsPopupMenu_BeforePopup);
			// 
			// stateImageList
			// 
			this.stateImageList.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("stateImageList.ImageStream")));
			this.stateImageList.Images.SetKeyName(0, "grey");
			this.stateImageList.Images.SetKeyName(1, "green");
			this.stateImageList.Images.SetKeyName(2, "yellow");
			this.stateImageList.Images.SetKeyName(3, "red");
			this.stateImageList.Images.SetKeyName(4, "blue");
			// 
			// treeImageList
			// 
			this.treeImageList.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("treeImageList.ImageStream")));
			this.treeImageList.Images.SetKeyName(0, "root");
			this.treeImageList.Images.SetKeyName(1, "group");
			this.treeImageList.Images.SetKeyName(2, "file");
			// 
			// updateDetailsTimer
			// 
			this.updateDetailsTimer.Interval = 200;
			this.updateDetailsTimer.Tick += new System.EventHandler(this.updateDetailsTimer_Tick);
			// 
			// ResourceEditorUserControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.resourceEditorUserControlMainSplitContainer);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "ResourceEditorUserControl";
			resources.ApplyResources(this, "$this");
			this.Load += new System.EventHandler(this.resourceEditorUserControlNew_Load);
			this.SizeChanged += new System.EventHandler(this.resourceEditorUserControlNew_SizeChanged);
			((System.ComponentModel.ISupportInitialize)(this.resourceEditorUserControlMainSplitContainer)).EndInit();
			this.resourceEditorUserControlMainSplitContainer.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popupImageCollection)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.statusPictureBox)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.optionsPopupMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stateImageList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.treeImageList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.SplitContainerControl resourceEditorUserControlMainSplitContainer;
		private DevExpress.XtraBars.PopupMenu optionsPopupMenu;
		private DevExpress.XtraBars.BarManager barManager;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.Utils.ImageCollection popupImageCollection;
		private DevExpress.XtraGrid.GridControl mainDataGrid;
		private DevExpress.XtraGrid.Views.Grid.GridView mainGridView;
		private DevExpress.XtraTab.XtraTabControl tabControl1;
		private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
		private DevExpress.XtraEditors.SimpleButton updateInGridButton;
		private DevExpress.Utils.ImageCollection stateImageList;
		private DevExpress.Utils.ImageCollection treeImageList;
		private DevExpress.XtraBars.BarButtonItem buttonAddTag;
		private DevExpress.XtraBars.BarButtonItem buttonEditTag;
		private DevExpress.XtraBars.BarButtonItem buttonDeleteTag;
		private DevExpress.Utils.ImageCollection imageCollection1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Timer updateDetailsTimer;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private System.Windows.Forms.PictureBox statusPictureBox;
		private DevExpress.XtraBars.BarButtonItem buttonSelectAllInGrid;
		private DevExpress.XtraBars.BarButtonItem buttonCopySelectedRowsToClipboard;
		private DevExpress.XtraEditors.LabelControl fileNameTextEdit;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraBars.BarButtonItem buttonDeleteRowContents;
		private DevExpress.XtraBars.BarButtonItem buttonDeleteSelectedContents;
	}
}
