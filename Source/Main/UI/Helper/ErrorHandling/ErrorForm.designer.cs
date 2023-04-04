namespace ZetaResourceEditor.UI.Helper.ErrorHandling
{
	partial class ErrorForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new Container();
			ComponentResourceManager resources = new ComponentResourceManager(typeof(ErrorForm));
			buttonContinue = new ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton();
			optionsButton = new ExtendedControlsLibrary.Skinning.CustomDropDownButton.MyDropDownButton();
			optionsPopupMenu = new PopupMenu(components);
			detailedErrorsButton = new BarButtonItem();
			barButtonItem1 = new BarButtonItem();
			barManager = new BarManager(components);
			barDockControlTop = new BarDockControl();
			barDockControlBottom = new BarDockControl();
			barDockControlLeft = new BarDockControl();
			barDockControlRight = new BarDockControl();
			memoEdit1 = new ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit();
			tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
			((ISupportInitialize)optionsPopupMenu).BeginInit();
			((ISupportInitialize)barManager).BeginInit();
			((ISupportInitialize)memoEdit1.Properties).BeginInit();
			((ISupportInitialize)tablePanel1).BeginInit();
			tablePanel1.SuspendLayout();
			SuspendLayout();
			// 
			// buttonContinue
			// 
			buttonContinue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			buttonContinue.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			buttonContinue.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(buttonContinue, 2);
			buttonContinue.DialogResult = DialogResult.OK;
			buttonContinue.Location = new Point(357, 285);
			buttonContinue.Margin = new Padding(0);
			buttonContinue.Name = "buttonContinue";
			tablePanel1.SetRow(buttonContinue, 2);
			buttonContinue.Size = new Size(75, 28);
			buttonContinue.TabIndex = 0;
			buttonContinue.Text = "OK";
			buttonContinue.WantDrawFocusRectangle = true;
			// 
			// optionsButton
			// 
			optionsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			optionsButton.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			optionsButton.Appearance.Options.UseFont = true;
			tablePanel1.SetColumn(optionsButton, 0);
			optionsButton.DropDownArrowStyle = DropDownArrowStyle.Hide;
			optionsButton.DropDownControl = optionsPopupMenu;
			optionsButton.ImageOptions.Image = (Image)resources.GetObject("optionsButton.ImageOptions.Image");
			optionsButton.ImageOptions.Location = ImageLocation.MiddleCenter;
			optionsButton.Location = new Point(16, 285);
			optionsButton.Margin = new Padding(0);
			optionsButton.Name = "optionsButton";
			tablePanel1.SetRow(optionsButton, 2);
			optionsButton.Size = new Size(28, 28);
			optionsButton.TabIndex = 1;
			// 
			// optionsPopupMenu
			// 
			optionsPopupMenu.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(detailedErrorsButton), new LinkPersistInfo(barButtonItem1) });
			optionsPopupMenu.Manager = barManager;
			optionsPopupMenu.Name = "optionsPopupMenu";
			optionsPopupMenu.BeforePopup += optionsPopupMenu_BeforePopup;
			// 
			// detailedErrorsButton
			// 
			detailedErrorsButton.Caption = "Details";
			detailedErrorsButton.Id = 0;
			detailedErrorsButton.Name = "detailedErrorsButton";
			detailedErrorsButton.ItemClick += detailedErrorsButton_ItemClick;
			// 
			// barButtonItem1
			// 
			barButtonItem1.Caption = "Quit";
			barButtonItem1.Id = 3;
			barButtonItem1.Name = "barButtonItem1";
			barButtonItem1.ItemClick += barButtonItem1_ItemClick;
			// 
			// barManager
			// 
			barManager.DockControls.Add(barDockControlTop);
			barManager.DockControls.Add(barDockControlBottom);
			barManager.DockControls.Add(barDockControlLeft);
			barManager.DockControls.Add(barDockControlRight);
			barManager.Form = this;
			barManager.Items.AddRange(new BarItem[] { detailedErrorsButton, barButtonItem1 });
			barManager.MaxItemId = 4;
			// 
			// barDockControlTop
			// 
			barDockControlTop.CausesValidation = false;
			barDockControlTop.Dock = DockStyle.Top;
			barDockControlTop.Location = new Point(0, 0);
			barDockControlTop.Manager = barManager;
			barDockControlTop.Size = new Size(448, 0);
			// 
			// barDockControlBottom
			// 
			barDockControlBottom.CausesValidation = false;
			barDockControlBottom.Dock = DockStyle.Bottom;
			barDockControlBottom.Location = new Point(0, 329);
			barDockControlBottom.Manager = barManager;
			barDockControlBottom.Size = new Size(448, 0);
			// 
			// barDockControlLeft
			// 
			barDockControlLeft.CausesValidation = false;
			barDockControlLeft.Dock = DockStyle.Left;
			barDockControlLeft.Location = new Point(0, 0);
			barDockControlLeft.Manager = barManager;
			barDockControlLeft.Size = new Size(0, 329);
			// 
			// barDockControlRight
			// 
			barDockControlRight.CausesValidation = false;
			barDockControlRight.Dock = DockStyle.Right;
			barDockControlRight.Location = new Point(448, 0);
			barDockControlRight.Manager = barManager;
			barDockControlRight.Size = new Size(0, 329);
			// 
			// memoEdit1
			// 
			tablePanel1.SetColumn(memoEdit1, 0);
			tablePanel1.SetColumnSpan(memoEdit1, 3);
			memoEdit1.CueText = null;
			memoEdit1.Dock = DockStyle.Fill;
			memoEdit1.Location = new Point(16, 15);
			memoEdit1.Margin = new Padding(0);
			memoEdit1.Name = "memoEdit1";
			memoEdit1.Properties.Appearance.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			memoEdit1.Properties.Appearance.Options.UseBackColor = true;
			memoEdit1.Properties.Appearance.Options.UseFont = true;
			memoEdit1.Properties.BorderStyle = BorderStyles.NoBorder;
			memoEdit1.Properties.NullValuePrompt = null;
			memoEdit1.Properties.ReadOnly = true;
			memoEdit1.Properties.ScrollBars = ScrollBars.None;
			memoEdit1.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.EditorFocused | ShowNullValuePromptOptions.EditorReadOnly;
			tablePanel1.SetRow(memoEdit1, 0);
			memoEdit1.Size = new Size(416, 261);
			memoEdit1.TabIndex = 2;
			// 
			// tablePanel1
			// 
			tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 75F) });
			tablePanel1.Controls.Add(memoEdit1);
			tablePanel1.Controls.Add(buttonContinue);
			tablePanel1.Controls.Add(optionsButton);
			tablePanel1.Dock = DockStyle.Fill;
			tablePanel1.Location = new Point(0, 0);
			tablePanel1.Name = "tablePanel1";
			tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 9F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F) });
			tablePanel1.Size = new Size(448, 329);
			tablePanel1.TabIndex = 0;
			tablePanel1.UseSkinIndents = true;
			// 
			// ErrorForm
			// 
			Appearance.Options.UseFont = true;
			AutoScaleMode = AutoScaleMode.None;
			ClientSize = new Size(448, 329);
			ControlBox = false;
			Controls.Add(tablePanel1);
			Controls.Add(barDockControlLeft);
			Controls.Add(barDockControlRight);
			Controls.Add(barDockControlBottom);
			Controls.Add(barDockControlTop);
			Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			IconOptions.Icon = (Icon)resources.GetObject("ErrorForm.IconOptions.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			MinimumSize = new Size(326, 270);
			Name = "ErrorForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Zeta Resource Editor";
			FormClosing += errorForm_FormClosing;
			Load += errorForm_Load;
			((ISupportInitialize)optionsPopupMenu).EndInit();
			((ISupportInitialize)barManager).EndInit();
			((ISupportInitialize)memoEdit1.Properties).EndInit();
			((ISupportInitialize)tablePanel1).EndInit();
			tablePanel1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ExtendedControlsLibrary.Skinning.CustomButton.MySimpleButton buttonContinue;
		private ExtendedControlsLibrary.Skinning.CustomDropDownButton.MyDropDownButton optionsButton;
		private ExtendedControlsLibrary.Skinning.CustomMemoEdit.MyMemoEdit memoEdit1;
		private DevExpress.XtraBars.PopupMenu optionsPopupMenu;
		private DevExpress.XtraBars.BarButtonItem detailedErrorsButton;
		private DevExpress.XtraBars.BarManager barManager;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DevExpress.Utils.Layout.TablePanel tablePanel1;
	}
}