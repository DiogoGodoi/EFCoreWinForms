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
			panelRodape = new Panel();
			tbLblRodape = new TableLayoutPanel();
			lblNivel = new Label();
			menuStrip1 = new MenuStrip();
			menuStripLogout = new ToolStripMenuItem();
			panelSideMenu = new Panel();
			tableLayoutPanel1 = new TableLayoutPanel();
			btnSair = new Button();
			btnInventario = new Button();
			btnUsuario = new Button();
			btnProduto = new Button();
			btnEstoque = new Button();
			tbPanelSideMenu = new TableLayoutPanel();
			panelRodape.SuspendLayout();
			tbLblRodape.SuspendLayout();
			menuStrip1.SuspendLayout();
			panelSideMenu.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// panelRodape
			// 
			panelRodape.BorderStyle = BorderStyle.FixedSingle;
			panelRodape.Controls.Add(tbLblRodape);
			panelRodape.Dock = DockStyle.Bottom;
			panelRodape.Location = new Point(0, 541);
			panelRodape.Name = "panelRodape";
			panelRodape.Size = new Size(965, 45);
			panelRodape.TabIndex = 0;
			// 
			// tbLblRodape
			// 
			tbLblRodape.ColumnCount = 1;
			tbLblRodape.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tbLblRodape.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tbLblRodape.Controls.Add(lblNivel, 0, 0);
			tbLblRodape.Dock = DockStyle.Fill;
			tbLblRodape.Location = new Point(0, 0);
			tbLblRodape.Name = "tbLblRodape";
			tbLblRodape.RowCount = 1;
			tbLblRodape.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tbLblRodape.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tbLblRodape.Size = new Size(963, 43);
			tbLblRodape.TabIndex = 0;
			// 
			// lblNivel
			// 
			lblNivel.AutoSize = true;
			lblNivel.BackColor = SystemColors.Control;
			lblNivel.Dock = DockStyle.Fill;
			lblNivel.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblNivel.Location = new Point(3, 0);
			lblNivel.Name = "lblNivel";
			lblNivel.Size = new Size(957, 43);
			lblNivel.TabIndex = 1;
			lblNivel.Text = "Nível";
			lblNivel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { menuStripLogout });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(965, 24);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// menuStripLogout
			// 
			menuStripLogout.Name = "menuStripLogout";
			menuStripLogout.Size = new Size(57, 20);
			menuStripLogout.Text = "Logout";
			// 
			// panelSideMenu
			// 
			panelSideMenu.BorderStyle = BorderStyle.FixedSingle;
			panelSideMenu.Controls.Add(tableLayoutPanel1);
			panelSideMenu.Dock = DockStyle.Left;
			panelSideMenu.Location = new Point(0, 24);
			panelSideMenu.Name = "panelSideMenu";
			panelSideMenu.Padding = new Padding(10);
			panelSideMenu.Size = new Size(110, 517);
			panelSideMenu.TabIndex = 2;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(btnSair, 0, 4);
			tableLayoutPanel1.Controls.Add(btnInventario, 0, 3);
			tableLayoutPanel1.Controls.Add(btnUsuario, 0, 2);
			tableLayoutPanel1.Controls.Add(btnProduto, 0, 1);
			tableLayoutPanel1.Controls.Add(btnEstoque, 0, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(10, 10);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 5;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.Size = new Size(88, 495);
			tableLayoutPanel1.TabIndex = 3;
			// 
			// btnSair
			// 
			btnSair.Dock = DockStyle.Fill;
			btnSair.FlatStyle = FlatStyle.Flat;
			btnSair.Location = new Point(3, 399);
			btnSair.Name = "btnSair";
			btnSair.Size = new Size(82, 93);
			btnSair.TabIndex = 4;
			btnSair.Text = "Sair";
			btnSair.UseVisualStyleBackColor = true;
			// 
			// btnInventario
			// 
			btnInventario.Dock = DockStyle.Fill;
			btnInventario.FlatStyle = FlatStyle.Flat;
			btnInventario.Location = new Point(3, 300);
			btnInventario.Name = "btnInventario";
			btnInventario.Size = new Size(82, 93);
			btnInventario.TabIndex = 3;
			btnInventario.Text = "Inventário";
			btnInventario.UseVisualStyleBackColor = true;
			// 
			// btnUsuario
			// 
			btnUsuario.Dock = DockStyle.Fill;
			btnUsuario.FlatStyle = FlatStyle.Flat;
			btnUsuario.Location = new Point(3, 201);
			btnUsuario.Name = "btnUsuario";
			btnUsuario.Size = new Size(82, 93);
			btnUsuario.TabIndex = 2;
			btnUsuario.Text = "Usuarios";
			btnUsuario.UseVisualStyleBackColor = true;
			// 
			// btnProduto
			// 
			btnProduto.Dock = DockStyle.Fill;
			btnProduto.FlatStyle = FlatStyle.Flat;
			btnProduto.Location = new Point(3, 102);
			btnProduto.Name = "btnProduto";
			btnProduto.Size = new Size(82, 93);
			btnProduto.TabIndex = 1;
			btnProduto.Text = "Produtos";
			btnProduto.UseVisualStyleBackColor = true;
			// 
			// btnEstoque
			// 
			btnEstoque.Dock = DockStyle.Fill;
			btnEstoque.FlatStyle = FlatStyle.Flat;
			btnEstoque.Location = new Point(3, 3);
			btnEstoque.Name = "btnEstoque";
			btnEstoque.Size = new Size(82, 93);
			btnEstoque.TabIndex = 0;
			btnEstoque.Text = "Estoque";
			btnEstoque.UseVisualStyleBackColor = true;
			// 
			// tbPanelSideMenu
			// 
			tbPanelSideMenu.ColumnCount = 1;
			tbPanelSideMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tbPanelSideMenu.Dock = DockStyle.Left;
			tbPanelSideMenu.Location = new Point(0, 0);
			tbPanelSideMenu.Name = "tbPanelSideMenu";
			tbPanelSideMenu.RowCount = 5;
			tbPanelSideMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tbPanelSideMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tbPanelSideMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tbPanelSideMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tbPanelSideMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tbPanelSideMenu.Size = new Size(200, 100);
			tbPanelSideMenu.TabIndex = 0;
			// 
			// frmMenu
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(965, 586);
			Controls.Add(panelSideMenu);
			Controls.Add(panelRodape);
			Controls.Add(menuStrip1);
			IsMdiContainer = true;
			MainMenuStrip = menuStrip1;
			Name = "frmMenu";
			Text = "Menu";
			Load += frmMenu_Load;
			panelRodape.ResumeLayout(false);
			tbLblRodape.ResumeLayout(false);
			tbLblRodape.PerformLayout();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			panelSideMenu.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panelRodape;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem menuStripLogout;
		private Panel panelSideMenu;
		private TableLayoutPanel tableLayoutPanel1;
		private Button btnSair;
		private Button btnInventario;
		private Button btnUsuario;
		private Button btnProduto;
		private Button btnEstoque;
		private TableLayoutPanel tbPanelSideMenu;
		private TableLayoutPanel tbLblRodape;
		private Label lblNivel;
	}
}