namespace ZetaResourceEditor.UI.Projects
{
	partial class CreateNewProjectForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new Container();
			ComponentResourceManager resources = new ComponentResourceManager(typeof(CreateNewProjectForm));
			button1 = new ExtendedControlsLibrary.Skinning.CustomDropDownButton.MyDropDownButton();
			optionsPopupMenu = new PopupMenu(components);
			browseButton = new BarButtonItem();
			openButton = new BarButtonItem();
			barManager = new BarManager(components);
			barDockControlTop = new BarDockControl();
			barDockControlBottom = new BarDockControl();
			barDockControlLeft = new BarDockControl();
			barDockControlRight = new BarDockControl();
			locationTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			nameTextBox = new ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit();
			label2 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			label1 = new ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl();
			buttonCancel = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			buttonOK = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			panelControl1 = new ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl();
			tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
			((ISupportInitialize)optionsPopupMenu).BeginInit();
			((ISupportInitialize)barManager).BeginInit();
			((ISupportInitialize)locationTextBox.Properties).BeginInit();
			((ISupportInitialize)nameTextBox.Properties).BeginInit();
			((ISupportInitialize)panelControl1).BeginInit();
			((ISupportInitialize)tablePanel1).BeginInit();
			tablePanel1.SuspendLayout();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			button1.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			button1.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(button1, 4);
			button1.DropDownArrowStyle = DropDownArrowStyle.Hide;
			button1.DropDownControl = optionsPopupMenu;
			button1.ImageOptions.Image = (Image)resources.GetObject("button1.ImageOptions.Image");
			button1.ImageOptions.Location = ImageLocation.MiddleCenter;
			button1.Location = new Point(387, 40);
			button1.Margin = new Padding(0);
			button1.Name = "button1";
			tablePanel1.SetRow(button1, 1);
			button1.Size = new Size(28, 24);
			button1.TabIndex = 4;
			// 
			// optionsPopupMenu
			// 
			optionsPopupMenu.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(browseButton), new LinkPersistInfo(openButton, true) });
			optionsPopupMenu.Manager = barManager;
			optionsPopupMenu.Name = "optionsPopupMenu";
			optionsPopupMenu.BeforePopup += contextMenuStrip1_Opening;
			// 
			// browseButton
			// 
			browseButton.Caption = "&Browse";
			browseButton.Id = 0;
			browseButton.Name = "browseButton";
			browseButton.ItemClick += browseButton_ItemClick;
			// 
			// openButton
			// 
			openButton.Caption = "&Open folder";
			openButton.Id = 0;
			openButton.Name = "openButton";
			openButton.ItemClick += openButton_ItemClick;
			// 
			// barManager
			// 
			barManager.DockControls.Add(barDockControlTop);
			barManager.DockControls.Add(barDockControlBottom);
			barManager.DockControls.Add(barDockControlLeft);
			barManager.DockControls.Add(barDockControlRight);
			barManager.Form = this;
			barManager.Items.AddRange(new BarItem[] { browseButton, openButton });
			barManager.MaxItemId = 3;
			// 
			// barDockControlTop
			// 
			barDockControlTop.CausesValidation = false;
			barDockControlTop.Dock = DockStyle.Top;
			barDockControlTop.Location = new Point(0, 0);
			barDockControlTop.Manager = barManager;
			barDockControlTop.Size = new Size(426, 0);
			// 
			// barDockControlBottom
			// 
			barDockControlBottom.CausesValidation = false;
			barDockControlBottom.Dock = DockStyle.Bottom;
			barDockControlBottom.Location = new Point(0, 122);
			barDockControlBottom.Manager = barManager;
			barDockControlBottom.Size = new Size(426, 0);
			// 
			// barDockControlLeft
			// 
			barDockControlLeft.CausesValidation = false;
			barDockControlLeft.Dock = DockStyle.Left;
			barDockControlLeft.Location = new Point(0, 0);
			barDockControlLeft.Manager = barManager;
			barDockControlLeft.Size = new Size(0, 122);
			// 
			// barDockControlRight
			// 
			barDockControlRight.CausesValidation = false;
			barDockControlRight.Dock = DockStyle.Right;
			barDockControlRight.Location = new Point(426, 0);
			barDockControlRight.Manager = barManager;
			barDockControlRight.Size = new Size(0, 122);
			// 
			// locationTextBox
			// 
			locationTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tablePanel1.SetColumn(locationTextBox, 1);
			tablePanel1.SetColumnSpan(locationTextBox, 3);
			locationTextBox.CueText = null;
			locationTextBox.Location = new Point(69, 40);
			locationTextBox.Margin = new Padding(0, 0, 3, 0);
			locationTextBox.MaximumSize = new Size(0, 24);
			locationTextBox.MinimumSize = new Size(0, 24);
			locationTextBox.Name = "locationTextBox";
			locationTextBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			locationTextBox.Properties.Appearance.Options.UseFont = true;
			locationTextBox.Properties.NullValuePrompt = null;
			locationTextBox.Properties.ReadOnly = true;
			locationTextBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel1.SetRow(locationTextBox, 1);
			locationTextBox.Size = new Size(315, 24);
			locationTextBox.TabIndex = 3;
			locationTextBox.TextChanged += locationTextBox_TextChanged;
			// 
			// nameTextBox
			// 
			nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tablePanel1.SetColumn(nameTextBox, 1);
			tablePanel1.SetColumnSpan(nameTextBox, 5);
			nameTextBox.CueText = null;
			nameTextBox.Location = new Point(69, 10);
			nameTextBox.Margin = new Padding(0, 0, 0, 6);
			nameTextBox.MaximumSize = new Size(0, 24);
			nameTextBox.MinimumSize = new Size(0, 24);
			nameTextBox.Name = "nameTextBox";
			nameTextBox.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			nameTextBox.Properties.Appearance.Options.UseFont = true;
			nameTextBox.Properties.NullValuePrompt = null;
			nameTextBox.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel1.SetRow(nameTextBox, 0);
			nameTextBox.Size = new Size(346, 24);
			nameTextBox.TabIndex = 1;
			nameTextBox.TextChanged += textBox1_TextChanged;
			// 
			// label2
			// 
			label2.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(label2, 0);
			label2.Location = new Point(11, 43);
			label2.Margin = new Padding(0, 0, 6, 0);
			label2.Name = "label2";
			tablePanel1.SetRow(label2, 1);
			label2.Size = new Size(52, 17);
			label2.TabIndex = 2;
			label2.Text = "&Location:";
			// 
			// label1
			// 
			label1.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(label1, 0);
			label1.Location = new Point(11, 13);
			label1.Margin = new Padding(0, 0, 6, 0);
			label1.Name = "label1";
			tablePanel1.SetRow(label1, 0);
			label1.Size = new Size(38, 17);
			label1.TabIndex = 0;
			label1.Text = "&Name:";
			// 
			// buttonCancel
			// 
			buttonCancel.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonCancel.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(buttonCancel, 3);
			tablePanel1.SetColumnSpan(buttonCancel, 2);
			buttonCancel.DialogResult = DialogResult.Cancel;
			buttonCancel.Dock = DockStyle.Fill;
			buttonCancel.Location = new Point(340, 83);
			buttonCancel.Margin = new Padding(0);
			buttonCancel.Name = "buttonCancel";
			tablePanel1.SetRow(buttonCancel, 3);
			buttonCancel.Size = new Size(75, 28);
			buttonCancel.TabIndex = 6;
			buttonCancel.Text = "Cancel";
			// 
			// buttonOK
			// 
			buttonOK.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			buttonOK.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(buttonOK, 2);
			buttonOK.DialogResult = DialogResult.OK;
			buttonOK.Dock = DockStyle.Fill;
			buttonOK.Location = new Point(256, 83);
			buttonOK.Margin = new Padding(0, 0, 9, 0);
			buttonOK.Name = "buttonOK";
			tablePanel1.SetRow(buttonOK, 3);
			buttonOK.Size = new Size(75, 28);
			buttonOK.TabIndex = 5;
			buttonOK.Text = "OK";
			buttonOK.Click += buttonOK_Click;
			// 
			// panelControl1
			// 
			panelControl1.Appearance.BackColor = Color.Transparent;
			panelControl1.Appearance.Options.UseBackColor = true;
			panelControl1.BorderStyle = BorderStyles.NoBorder;
			panelControl1.Dock = DockStyle.Fill;
			panelControl1.Location = new Point(0, 0);
			panelControl1.Name = "panelControl1";
			panelControl1.Padding = new Padding(9);
			panelControl1.Size = new Size(426, 122);
			panelControl1.TabIndex = 0;
			// 
			// tablePanel1
			// 
			tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 84F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 47F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel1.Controls.Add(buttonCancel);
			tablePanel1.Controls.Add(buttonOK);
			tablePanel1.Controls.Add(button1);
			tablePanel1.Controls.Add(label1);
			tablePanel1.Controls.Add(label2);
			tablePanel1.Controls.Add(nameTextBox);
			tablePanel1.Controls.Add(locationTextBox);
			tablePanel1.Dock = DockStyle.Fill;
			tablePanel1.Location = new Point(0, 0);
			tablePanel1.Margin = new Padding(0);
			tablePanel1.Name = "tablePanel1";
			tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel1.Size = new Size(426, 122);
			tablePanel1.TabIndex = 0;
			tablePanel1.UseSkinIndents = true;
			// 
			// CreateNewProjectForm
			// 
			AcceptButton = buttonOK;
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = buttonCancel;
			ClientSize = new Size(426, 122);
			Controls.Add(tablePanel1);
			Controls.Add(panelControl1);
			Controls.Add(barDockControlLeft);
			Controls.Add(barDockControlRight);
			Controls.Add(barDockControlBottom);
			Controls.Add(barDockControlTop);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			IconOptions.ShowIcon = false;
			MaximizeBox = false;
			MaximumSize = new Size(1024, 184);
			MinimizeBox = false;
			Name = "CreateNewProjectForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Create new project";
			FormClosing += CreateNewProjectForm_FormClosing;
			Load += CreateNewProjectForm_Load;
			((ISupportInitialize)optionsPopupMenu).EndInit();
			((ISupportInitialize)barManager).EndInit();
			((ISupportInitialize)locationTextBox.Properties).EndInit();
			((ISupportInitialize)nameTextBox.Properties).EndInit();
			((ISupportInitialize)panelControl1).EndInit();
			((ISupportInitialize)tablePanel1).EndInit();
			tablePanel1.ResumeLayout(false);
			tablePanel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonCancel;
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonOK;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit locationTextBox;
		private ExtendedControlsLibrary.Skinning.CustomTextEdit.MyTextEdit nameTextBox;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label2;
		private ExtendedControlsLibrary.Skinning.CustomLabelEdit.MyLabelControl label1;
		private PopupMenu optionsPopupMenu;
		private BarButtonItem openButton;
		private BarManager barManager;
		private BarDockControl barDockControlTop;
		private BarDockControl barDockControlBottom;
		private BarDockControl barDockControlLeft;
		private BarDockControl barDockControlRight;
		private BarButtonItem browseButton;
		private ExtendedControlsLibrary.Skinning.CustomDropDownButton.MyDropDownButton button1;
		private ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl panelControl1;
		private DevExpress.Utils.Layout.TablePanel tablePanel1;
	}
}