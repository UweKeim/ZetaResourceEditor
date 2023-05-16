namespace ZetaResourceEditor.UI.Helper
{
	partial class InformationLightUserControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			backgroundPanel = new Panel();
			descriptionLabel = new Label();
			backgroundPanel.SuspendLayout();
			SuspendLayout();
			// 
			// backgroundPanel
			// 
			backgroundPanel.BackColor = SystemColors.Info;
			backgroundPanel.Controls.Add(descriptionLabel);
			backgroundPanel.Dock = DockStyle.Fill;
			backgroundPanel.Location = new Point(1, 1);
			backgroundPanel.Margin = new Padding(1);
			backgroundPanel.Name = "backgroundPanel";
			backgroundPanel.Padding = new Padding(3);
			backgroundPanel.Size = new Size(165, 25);
			backgroundPanel.TabIndex = 0;
			// 
			// descriptionLabel
			// 
			descriptionLabel.Dock = DockStyle.Fill;
			descriptionLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			descriptionLabel.Location = new Point(3, 3);
			descriptionLabel.Margin = new Padding(0);
			descriptionLabel.Name = "descriptionLabel";
			descriptionLabel.Size = new Size(159, 19);
			descriptionLabel.TabIndex = 1;
			descriptionLabel.Text = "<DESCRIPTION>";
			// 
			// InformationLightUserControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Silver;
			Controls.Add(backgroundPanel);
			MinimumSize = new Size(167, 24);
			Name = "InformationLightUserControl";
			Padding = new Padding(1);
			Size = new Size(167, 27);
			Load += InformationLightUserControl_Load;
			MouseEnter += InformationLightUserControl_MouseEnter;
			MouseLeave += InformationLightUserControl_MouseLeave;
			backgroundPanel.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel backgroundPanel;
		private Label descriptionLabel;
	}
}
