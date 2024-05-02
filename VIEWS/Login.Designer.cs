namespace VIEWS
{
	partial class frmLogin
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			stripMenuHeader = new MenuStrip();
			arquivoToolStripMenuItem = new ToolStripMenuItem();
			toolMenuSair = new ToolStripMenuItem();
			panelFooter = new Panel();
			stripFooterMenu = new Panel();
			tbContent = new TableLayoutPanel();
			panelContent = new Panel();
			panelContentLogin = new Panel();
			grpLogin = new GroupBox();
			tableLayoutPanel1 = new TableLayoutPanel();
			lblSenha = new Label();
			lblUsuario = new Label();
			txtUsuario = new TextBox();
			txtSenha = new TextBox();
			tbContentButton = new TableLayoutPanel();
			btnSair = new Button();
			btnEntrar = new Button();
			tbLogo = new TableLayoutPanel();
			pictLogo = new PictureBox();
			panelTitle = new Panel();
			lblTitulo = new Label();
			stripMenuHeader.SuspendLayout();
			stripFooterMenu.SuspendLayout();
			tbContent.SuspendLayout();
			panelContent.SuspendLayout();
			panelContentLogin.SuspendLayout();
			grpLogin.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			tbContentButton.SuspendLayout();
			tbLogo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictLogo).BeginInit();
			panelTitle.SuspendLayout();
			SuspendLayout();
			// 
			// stripMenuHeader
			// 
			stripMenuHeader.BackColor = SystemColors.ButtonFace;
			stripMenuHeader.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem });
			stripMenuHeader.Location = new Point(0, 0);
			stripMenuHeader.Name = "stripMenuHeader";
			stripMenuHeader.Size = new Size(414, 24);
			stripMenuHeader.TabIndex = 1;
			stripMenuHeader.Text = "menuStrip2";
			// 
			// arquivoToolStripMenuItem
			// 
			arquivoToolStripMenuItem.BackColor = SystemColors.ButtonFace;
			arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolMenuSair });
			arquivoToolStripMenuItem.Image = (Image)resources.GetObject("arquivoToolStripMenuItem.Image");
			arquivoToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
			arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
			arquivoToolStripMenuItem.Size = new Size(77, 20);
			arquivoToolStripMenuItem.Text = "Arquivo";
			// 
			// toolMenuSair
			// 
			toolMenuSair.Image = (Image)resources.GetObject("toolMenuSair.Image");
			toolMenuSair.ImageAlign = ContentAlignment.MiddleLeft;
			toolMenuSair.Name = "toolMenuSair";
			toolMenuSair.Size = new Size(180, 22);
			toolMenuSair.Text = "Sair";
			// 
			// panelFooter
			// 
			panelFooter.Dock = DockStyle.Bottom;
			panelFooter.Location = new Point(0, 484);
			panelFooter.Name = "panelFooter";
			panelFooter.Size = new Size(414, 29);
			panelFooter.TabIndex = 2;
			// 
			// stripFooterMenu
			// 
			stripFooterMenu.BackColor = SystemColors.ControlDark;
			stripFooterMenu.Controls.Add(tbContent);
			stripFooterMenu.Dock = DockStyle.Fill;
			stripFooterMenu.Location = new Point(0, 24);
			stripFooterMenu.Name = "stripFooterMenu";
			stripFooterMenu.Padding = new Padding(40);
			stripFooterMenu.Size = new Size(414, 460);
			stripFooterMenu.TabIndex = 5;
			// 
			// tbContent
			// 
			tbContent.ColumnCount = 1;
			tbContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tbContent.Controls.Add(panelContent, 0, 2);
			tbContent.Controls.Add(panelTitle, 0, 0);
			tbContent.Dock = DockStyle.Fill;
			tbContent.Location = new Point(40, 40);
			tbContent.Name = "tbContent";
			tbContent.RowCount = 3;
			tbContent.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tbContent.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
			tbContent.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
			tbContent.Size = new Size(334, 380);
			tbContent.TabIndex = 0;
			// 
			// panelContent
			// 
			panelContent.BorderStyle = BorderStyle.FixedSingle;
			panelContent.Controls.Add(panelContentLogin);
			panelContent.Controls.Add(tbLogo);
			panelContent.Dock = DockStyle.Fill;
			panelContent.Location = new Point(3, 98);
			panelContent.Name = "panelContent";
			panelContent.Size = new Size(328, 279);
			panelContent.TabIndex = 1;
			// 
			// panelContentLogin
			// 
			panelContentLogin.BackColor = SystemColors.Control;
			panelContentLogin.Controls.Add(grpLogin);
			panelContentLogin.Dock = DockStyle.Fill;
			panelContentLogin.Location = new Point(0, 97);
			panelContentLogin.Name = "panelContentLogin";
			panelContentLogin.Padding = new Padding(10);
			panelContentLogin.Size = new Size(326, 180);
			panelContentLogin.TabIndex = 1;
			// 
			// grpLogin
			// 
			grpLogin.BackColor = SystemColors.Control;
			grpLogin.Controls.Add(tableLayoutPanel1);
			grpLogin.Controls.Add(tbContentButton);
			grpLogin.Dock = DockStyle.Fill;
			grpLogin.FlatStyle = FlatStyle.Popup;
			grpLogin.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			grpLogin.Location = new Point(10, 10);
			grpLogin.Name = "grpLogin";
			grpLogin.Padding = new Padding(10);
			grpLogin.Size = new Size(306, 160);
			grpLogin.TabIndex = 4;
			grpLogin.TabStop = false;
			grpLogin.Text = "Entrar";
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.57143F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.42857F));
			tableLayoutPanel1.Controls.Add(lblSenha, 0, 1);
			tableLayoutPanel1.Controls.Add(lblUsuario, 0, 0);
			tableLayoutPanel1.Controls.Add(txtUsuario, 1, 0);
			tableLayoutPanel1.Controls.Add(txtSenha, 1, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(10, 32);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.2813225F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.2813225F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.4373517F));
			tableLayoutPanel1.Size = new Size(286, 81);
			tableLayoutPanel1.TabIndex = 5;
			// 
			// lblSenha
			// 
			lblSenha.AutoSize = true;
			lblSenha.Dock = DockStyle.Fill;
			lblSenha.Location = new Point(3, 38);
			lblSenha.Name = "lblSenha";
			lblSenha.Size = new Size(75, 38);
			lblSenha.TabIndex = 6;
			lblSenha.Text = "Senha";
			lblSenha.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblUsuario
			// 
			lblUsuario.AutoSize = true;
			lblUsuario.Dock = DockStyle.Fill;
			lblUsuario.Location = new Point(3, 0);
			lblUsuario.Name = "lblUsuario";
			lblUsuario.Size = new Size(75, 38);
			lblUsuario.TabIndex = 0;
			lblUsuario.Text = "Usuário";
			lblUsuario.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txtUsuario
			// 
			txtUsuario.Anchor = AnchorStyles.None;
			txtUsuario.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
			txtUsuario.Location = new Point(84, 6);
			txtUsuario.Name = "txtUsuario";
			txtUsuario.PlaceholderText = "Digite o nome";
			txtUsuario.Size = new Size(199, 26);
			txtUsuario.TabIndex = 7;
			txtUsuario.TextAlign = HorizontalAlignment.Center;
			// 
			// txtSenha
			// 
			txtSenha.Anchor = AnchorStyles.None;
			txtSenha.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
			txtSenha.Location = new Point(84, 44);
			txtSenha.Name = "txtSenha";
			txtSenha.PasswordChar = '*';
			txtSenha.PlaceholderText = "Informe a senha";
			txtSenha.Size = new Size(199, 26);
			txtSenha.TabIndex = 8;
			txtSenha.TextAlign = HorizontalAlignment.Center;
			// 
			// tbContentButton
			// 
			tbContentButton.BackColor = SystemColors.Control;
			tbContentButton.ColumnCount = 2;
			tbContentButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tbContentButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tbContentButton.Controls.Add(btnSair, 1, 0);
			tbContentButton.Controls.Add(btnEntrar, 0, 0);
			tbContentButton.Dock = DockStyle.Bottom;
			tbContentButton.Location = new Point(10, 113);
			tbContentButton.Name = "tbContentButton";
			tbContentButton.RowCount = 1;
			tbContentButton.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tbContentButton.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tbContentButton.Size = new Size(286, 37);
			tbContentButton.TabIndex = 4;
			// 
			// btnSair
			// 
			btnSair.BackColor = Color.DarkRed;
			btnSair.Dock = DockStyle.Fill;
			btnSair.FlatStyle = FlatStyle.Popup;
			btnSair.Font = new Font("Times New Roman", 11.25F);
			btnSair.ForeColor = Color.White;
			btnSair.Location = new Point(146, 3);
			btnSair.Name = "btnSair";
			btnSair.Size = new Size(137, 31);
			btnSair.TabIndex = 1;
			btnSair.Text = "Sair";
			btnSair.UseVisualStyleBackColor = false;
			// 
			// btnEntrar
			// 
			btnEntrar.BackColor = Color.DarkGreen;
			btnEntrar.Dock = DockStyle.Fill;
			btnEntrar.FlatStyle = FlatStyle.Popup;
			btnEntrar.Font = new Font("Times New Roman", 11.25F);
			btnEntrar.ForeColor = Color.White;
			btnEntrar.Location = new Point(3, 3);
			btnEntrar.Name = "btnEntrar";
			btnEntrar.Size = new Size(137, 31);
			btnEntrar.TabIndex = 0;
			btnEntrar.Text = "Entrar";
			btnEntrar.UseVisualStyleBackColor = false;
			btnEntrar.Click += btnEntrar_Click_1;
			// 
			// tbLogo
			// 
			tbLogo.BackColor = SystemColors.Control;
			tbLogo.ColumnCount = 3;
			tbLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			tbLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			tbLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			tbLogo.Controls.Add(pictLogo, 1, 0);
			tbLogo.Dock = DockStyle.Top;
			tbLogo.Location = new Point(0, 0);
			tbLogo.Name = "tbLogo";
			tbLogo.Padding = new Padding(10);
			tbLogo.RowCount = 1;
			tbLogo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tbLogo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tbLogo.Size = new Size(326, 97);
			tbLogo.TabIndex = 0;
			// 
			// pictLogo
			// 
			pictLogo.BorderStyle = BorderStyle.Fixed3D;
			pictLogo.Dock = DockStyle.Fill;
			pictLogo.Image = (Image)resources.GetObject("pictLogo.Image");
			pictLogo.Location = new Point(115, 13);
			pictLogo.Name = "pictLogo";
			pictLogo.Size = new Size(96, 71);
			pictLogo.SizeMode = PictureBoxSizeMode.Zoom;
			pictLogo.TabIndex = 0;
			pictLogo.TabStop = false;
			// 
			// panelTitle
			// 
			panelTitle.BackColor = SystemColors.Control;
			panelTitle.BorderStyle = BorderStyle.FixedSingle;
			panelTitle.Controls.Add(lblTitulo);
			panelTitle.Dock = DockStyle.Fill;
			panelTitle.Location = new Point(3, 3);
			panelTitle.Name = "panelTitle";
			panelTitle.Padding = new Padding(20);
			panelTitle.Size = new Size(328, 70);
			panelTitle.TabIndex = 2;
			// 
			// lblTitulo
			// 
			lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lblTitulo.AutoSize = true;
			lblTitulo.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTitulo.Location = new Point(39, 20);
			lblTitulo.Name = "lblTitulo";
			lblTitulo.Size = new Size(253, 31);
			lblTitulo.TabIndex = 0;
			lblTitulo.Text = "Controle de Estoque";
			lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// frmLogin
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			ClientSize = new Size(414, 513);
			ControlBox = false;
			Controls.Add(stripFooterMenu);
			Controls.Add(panelFooter);
			Controls.Add(stripMenuHeader);
			Name = "frmLogin";
			Text = "Entrar";
			stripMenuHeader.ResumeLayout(false);
			stripMenuHeader.PerformLayout();
			stripFooterMenu.ResumeLayout(false);
			tbContent.ResumeLayout(false);
			panelContent.ResumeLayout(false);
			panelContentLogin.ResumeLayout(false);
			grpLogin.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tbContentButton.ResumeLayout(false);
			tbLogo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictLogo).EndInit();
			panelTitle.ResumeLayout(false);
			panelTitle.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private MenuStrip stripMenuHeader;
		private ToolStripMenuItem arquivoToolStripMenuItem;
		private ToolStripMenuItem toolMenuSair;
		private Panel panelFooter;
		private Panel stripFooterMenu;
		private TableLayoutPanel tbContent;
		private Panel panelContent;
		private Panel panelContentLogin;
		private GroupBox grpLogin;
		private TableLayoutPanel tableLayoutPanel1;
		private Label lblSenha;
		private Label lblUsuario;
		private TextBox txtUsuario;
		private TextBox txtSenha;
		private TableLayoutPanel tbContentButton;
		private Button btnSair;
		private Button btnEntrar;
		private TableLayoutPanel tbLogo;
		private PictureBox pictLogo;
		private Panel panelTitle;
		private Label lblTitulo;
	}
}
