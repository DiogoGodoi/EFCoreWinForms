namespace VIEWS
{
	partial class frmMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
			panelContent = new Panel();
			pictBemVindo = new PictureBox();
			panelContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictBemVindo).BeginInit();
			SuspendLayout();
			// 
			// panelContent
			// 
			panelContent.Controls.Add(pictBemVindo);
			panelContent.Dock = DockStyle.Fill;
			panelContent.Location = new Point(0, 0);
			panelContent.Name = "panelContent";
			panelContent.Padding = new Padding(50);
			panelContent.Size = new Size(634, 450);
			panelContent.TabIndex = 0;
			// 
			// pictBemVindo
			// 
			pictBemVindo.Dock = DockStyle.Fill;
			pictBemVindo.Image = (Image)resources.GetObject("pictBemVindo.Image");
			pictBemVindo.Location = new Point(50, 50);
			pictBemVindo.Name = "pictBemVindo";
			pictBemVindo.Size = new Size(534, 350);
			pictBemVindo.SizeMode = PictureBoxSizeMode.StretchImage;
			pictBemVindo.TabIndex = 0;
			pictBemVindo.TabStop = false;
			// 
			// frmMenu
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(634, 450);
			Controls.Add(panelContent);
			Name = "frmMenu";
			Text = "Menu";
			panelContent.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictBemVindo).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panelContent;
		private PictureBox pictBemVindo;
	}
}