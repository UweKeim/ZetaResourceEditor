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
            this.buttonAddTag = new DevExpress.XtraBars.BarButtonItem();
            this.buttonEditTag = new DevExpress.XtraBars.BarButtonItem();
            this.buttonDeleteTag = new DevExpress.XtraBars.BarButtonItem();
            this.buttonSelectAllInGrid = new DevExpress.XtraBars.BarButtonItem();
            this.buttonCopySelectedRowsToClipboard = new DevExpress.XtraBars.BarButtonItem();
            this.buttonDeleteRowContents = new DevExpress.XtraBars.BarButtonItem();
            this.buttonDeleteSelectedContents = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl();
            this.fileNameTextEdit = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
            this.statusPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.xtraTabPage1 = new ExtendedControlsLibrary.Skinning.CustomTabControl.MyXtraTabPage();
            this.updateInGridButton = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
            this.labelControl1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
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
            this.resourceEditorUserControlMainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourceEditorUserControlMainSplitContainer.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.resourceEditorUserControlMainSplitContainer.Horizontal = false;
            this.resourceEditorUserControlMainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.resourceEditorUserControlMainSplitContainer.Name = "resourceEditorUserControlMainSplitContainer";
            this.resourceEditorUserControlMainSplitContainer.Panel1.AppearanceCaption.Image = ((System.Drawing.Image)(resources.GetObject("resourceEditorUserControlMainSplitContainer.Panel1.AppearanceCaption.Image")));
            this.resourceEditorUserControlMainSplitContainer.Panel1.AppearanceCaption.Options.UseImage = true;
            this.resourceEditorUserControlMainSplitContainer.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.resourceEditorUserControlMainSplitContainer.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.resourceEditorUserControlMainSplitContainer.Panel1.Text = "Resources grid";
            this.resourceEditorUserControlMainSplitContainer.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.resourceEditorUserControlMainSplitContainer.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.resourceEditorUserControlMainSplitContainer.Panel2.MinSize = 200;
            this.resourceEditorUserControlMainSplitContainer.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.resourceEditorUserControlMainSplitContainer.Panel2.Text = "Details view";
            this.resourceEditorUserControlMainSplitContainer.Size = new System.Drawing.Size(399, 467);
            this.resourceEditorUserControlMainSplitContainer.SplitterPosition = 188;
            this.resourceEditorUserControlMainSplitContainer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.mainDataGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(395, 258);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // mainDataGrid
            // 
            this.mainDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDataGrid.Location = new System.Drawing.Point(3, 24);
            this.mainDataGrid.MainView = this.mainGridView;
            this.mainDataGrid.MenuManager = this.barManager;
            this.mainDataGrid.Name = "mainDataGrid";
            this.mainDataGrid.Size = new System.Drawing.Size(389, 231);
            this.mainDataGrid.TabIndex = 1;
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
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(399, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 467);
            this.barDockControlBottom.Size = new System.Drawing.Size(399, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 467);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(399, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 467);
            // 
            // buttonAddTag
            // 
            this.buttonAddTag.Caption = "Add new tag";
            this.buttonAddTag.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonAddTag.Glyph")));
            this.buttonAddTag.Id = 3;
            this.buttonAddTag.Name = "buttonAddTag";
            this.buttonAddTag.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonAddTag_ItemClick);
            // 
            // buttonEditTag
            // 
            this.buttonEditTag.Caption = "Edit tag";
            this.buttonEditTag.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonEditTag.Glyph")));
            this.buttonEditTag.Id = 4;
            this.buttonEditTag.Name = "buttonEditTag";
            this.buttonEditTag.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonEditTag_ItemClick);
            // 
            // buttonDeleteTag
            // 
            this.buttonDeleteTag.Caption = "Delete tag";
            this.buttonDeleteTag.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonDeleteTag.Glyph")));
            this.buttonDeleteTag.Id = 5;
            this.buttonDeleteTag.Name = "buttonDeleteTag";
            this.buttonDeleteTag.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonDeleteTag_ItemClick);
            // 
            // buttonSelectAllInGrid
            // 
            this.buttonSelectAllInGrid.Caption = "Select all rows";
            this.buttonSelectAllInGrid.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonSelectAllInGrid.Glyph")));
            this.buttonSelectAllInGrid.Id = 6;
            this.buttonSelectAllInGrid.Name = "buttonSelectAllInGrid";
            this.buttonSelectAllInGrid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonSelectAllInGrid_ItemClick);
            // 
            // buttonCopySelectedRowsToClipboard
            // 
            this.buttonCopySelectedRowsToClipboard.Caption = "Copy selected rows to clipboard";
            this.buttonCopySelectedRowsToClipboard.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonCopySelectedRowsToClipboard.Glyph")));
            this.buttonCopySelectedRowsToClipboard.Id = 7;
            this.buttonCopySelectedRowsToClipboard.Name = "buttonCopySelectedRowsToClipboard";
            this.buttonCopySelectedRowsToClipboard.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonCopySelectedRowsToClipboard_ItemClick);
            // 
            // buttonDeleteRowContents
            // 
            this.buttonDeleteRowContents.Caption = "Delete row contents";
            this.buttonDeleteRowContents.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonDeleteRowContents.Glyph")));
            this.buttonDeleteRowContents.Id = 8;
            this.buttonDeleteRowContents.Name = "buttonDeleteRowContents";
            this.buttonDeleteRowContents.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonDeleteRowContents_ItemClick);
            // 
            // buttonDeleteSelectedContents
            // 
            this.buttonDeleteSelectedContents.Caption = "Delete selected contents";
            this.buttonDeleteSelectedContents.Id = 9;
            this.buttonDeleteSelectedContents.Name = "buttonDeleteSelectedContents";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.fileNameTextEdit);
            this.panelControl1.Controls.Add(this.statusPictureBox);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(3);
            this.panelControl1.Size = new System.Drawing.Size(395, 21);
            this.panelControl1.TabIndex = 2;
            // 
            // fileNameTextEdit
            // 
            this.fileNameTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameTextEdit.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fileNameTextEdit.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.fileNameTextEdit.Location = new System.Drawing.Point(25, 3);
            this.fileNameTextEdit.Name = "fileNameTextEdit";
            this.fileNameTextEdit.Size = new System.Drawing.Size(367, 15);
            this.fileNameTextEdit.TabIndex = 2;
            // 
            // statusPictureBox
            // 
            this.statusPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("statusPictureBox.Image")));
            this.statusPictureBox.Location = new System.Drawing.Point(3, 3);
            this.statusPictureBox.Name = "statusPictureBox";
            this.statusPictureBox.Size = new System.Drawing.Size(16, 16);
            this.statusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.statusPictureBox.TabIndex = 1;
            this.statusPictureBox.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.updateInGridButton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(389, 190);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.AppearancePage.Header.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabControl1.AppearancePage.Header.Options.UseFont = true;
            this.tabControl1.Images = this.imageCollection1;
            this.tabControl1.Location = new System.Drawing.Point(3, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabPage = this.xtraTabPage1;
            this.tabControl1.Size = new System.Drawing.Size(383, 129);
            this.tabControl1.TabIndex = 1;
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
            this.xtraTabPage1.Size = new System.Drawing.Size(377, 97);
            this.xtraTabPage1.Text = "<L>";
            // 
            // updateInGridButton
            // 
            this.updateInGridButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.updateInGridButton.Appearance.Options.UseFont = true;
            this.updateInGridButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.updateInGridButton.Location = new System.Drawing.Point(276, 159);
            this.updateInGridButton.Name = "updateInGridButton";
            this.updateInGridButton.Size = new System.Drawing.Size(110, 28);
            this.updateInGridButton.TabIndex = 2;
            this.updateInGridButton.Text = "&Update in grid";
            this.updateInGridButton.WantDrawFocusRectangle = true;
            this.updateInGridButton.Click += new System.EventHandler(this.updateInGridButton_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(383, 15);
            this.labelControl1.TabIndex = 3;
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
            this.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.resourceEditorUserControlMainSplitContainer);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ResourceEditorUserControl";
            this.Size = new System.Drawing.Size(399, 467);
            this.Load += new System.EventHandler(this.resourceEditorUserControlNew_Load);
            this.SizeChanged += new System.EventHandler(this.resourceEditorUserControlNew_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.resourceEditorUserControlMainSplitContainer)).EndInit();
            this.resourceEditorUserControlMainSplitContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
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
            this.PerformLayout();

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
		private DevExpress.Utils.ImageCollection stateImageList;
		private DevExpress.Utils.ImageCollection treeImageList;
		private DevExpress.XtraBars.BarButtonItem buttonAddTag;
		private DevExpress.XtraBars.BarButtonItem buttonEditTag;
		private DevExpress.XtraBars.BarButtonItem buttonDeleteTag;
		private DevExpress.Utils.ImageCollection imageCollection1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Timer updateDetailsTimer;
		private ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl panelControl1;
		private System.Windows.Forms.PictureBox statusPictureBox;
		private DevExpress.XtraBars.BarButtonItem buttonSelectAllInGrid;
		private DevExpress.XtraBars.BarButtonItem buttonCopySelectedRowsToClipboard;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl fileNameTextEdit;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl labelControl1;
		private DevExpress.XtraBars.BarButtonItem buttonDeleteRowContents;
		private DevExpress.XtraBars.BarButtonItem buttonDeleteSelectedContents;
	}
}
