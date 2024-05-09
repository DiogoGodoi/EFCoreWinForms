namespace VIEWS
{
	partial class frmUsuario
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
			panelContent = new Panel();
			panelDtGrid = new Panel();
			dtGridUsuarios = new DataGridView();
			panelPesquisa = new Panel();
			tbPanelPesquisa = new TableLayoutPanel();
			btnPesquisar = new Button();
			txtProcurar = new TextBox();
			lblNomeUsuario = new Label();
			panelSideMenu = new Panel();
			tableLayoutPanel1 = new TableLayoutPanel();
			btnSair = new Button();
			btnListar = new Button();
			btnDeletar = new Button();
			btnAtualizar = new Button();
			btnCadastrar = new Button();
			panelContent.SuspendLayout();
			panelDtGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dtGridUsuarios).BeginInit();
			panelPesquisa.SuspendLayout();
			tbPanelPesquisa.SuspendLayout();
			panelSideMenu.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// panelContent
			// 
			panelContent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			panelContent.Controls.Add(panelDtGrid);
			panelContent.Controls.Add(panelSideMenu);
			panelContent.Dock = DockStyle.Fill;
			panelContent.Location = new Point(0, 0);
			panelContent.Name = "panelContent";
			panelContent.Padding = new Padding(10);
			panelContent.Size = new Size(800, 450);
			panelContent.TabIndex = 0;
			// 
			// panelDtGrid
			// 
			panelDtGrid.Controls.Add(dtGridUsuarios);
			panelDtGrid.Controls.Add(panelPesquisa);
			panelDtGrid.Dock = DockStyle.Fill;
			panelDtGrid.Location = new Point(120, 10);
			panelDtGrid.Name = "panelDtGrid";
			panelDtGrid.Padding = new Padding(10);
			panelDtGrid.Size = new Size(670, 430);
			panelDtGrid.TabIndex = 4;
			// 
			// dtGridUsuarios
			// 
			dtGridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtGridUsuarios.Dock = DockStyle.Fill;
			dtGridUsuarios.Location = new Point(10, 89);
			dtGridUsuarios.MultiSelect = false;
			dtGridUsuarios.Name = "dtGridUsuarios";
			dtGridUsuarios.ReadOnly = true;
			dtGridUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dtGridUsuarios.Size = new Size(650, 331);
			dtGridUsuarios.TabIndex = 1;
			// 
			// panelPesquisa
			// 
			panelPesquisa.BorderStyle = BorderStyle.FixedSingle;
			panelPesquisa.Controls.Add(tbPanelPesquisa);
			panelPesquisa.Dock = DockStyle.Top;
			panelPesquisa.Location = new Point(10, 10);
			panelPesquisa.Name = "panelPesquisa";
			panelPesquisa.Padding = new Padding(10);
			panelPesquisa.Size = new Size(650, 79);
			panelPesquisa.TabIndex = 0;
			// 
			// tbPanelPesquisa
			// 
			tbPanelPesquisa.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
			tbPanelPesquisa.ColumnCount = 3;
			tbPanelPesquisa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tbPanelPesquisa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
			tbPanelPesquisa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tbPanelPesquisa.Controls.Add(btnPesquisar, 2, 0);
			tbPanelPesquisa.Controls.Add(txtProcurar, 1, 0);
			tbPanelPesquisa.Controls.Add(lblNomeUsuario, 0, 0);
			tbPanelPesquisa.Dock = DockStyle.Fill;
			tbPanelPesquisa.Location = new Point(10, 10);
			tbPanelPesquisa.Name = "tbPanelPesquisa";
			tbPanelPesquisa.RowCount = 1;
			tbPanelPesquisa.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tbPanelPesquisa.Size = new Size(628, 57);
			tbPanelPesquisa.TabIndex = 0;
			// 
			// btnPesquisar
			// 
			btnPesquisar.Dock = DockStyle.Fill;
			btnPesquisar.FlatStyle = FlatStyle.Flat;
			btnPesquisar.Location = new Point(504, 4);
			btnPesquisar.Name = "btnPesquisar";
			btnPesquisar.Size = new Size(120, 49);
			btnPesquisar.TabIndex = 1;
			btnPesquisar.Text = "Procurar";
			btnPesquisar.UseVisualStyleBackColor = true;
			// 
			// txtProcurar
			// 
			txtProcurar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			txtProcurar.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtProcurar.Location = new Point(129, 13);
			txtProcurar.Name = "txtProcurar";
			txtProcurar.PlaceholderText = "Digite o nome do usuário";
			txtProcurar.Size = new Size(368, 31);
			txtProcurar.TabIndex = 2;
			txtProcurar.TextAlign = HorizontalAlignment.Center;
			// 
			// lblNomeUsuario
			// 
			lblNomeUsuario.AutoSize = true;
			lblNomeUsuario.Dock = DockStyle.Fill;
			lblNomeUsuario.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblNomeUsuario.Location = new Point(4, 1);
			lblNomeUsuario.Name = "lblNomeUsuario";
			lblNomeUsuario.Size = new Size(118, 55);
			lblNomeUsuario.TabIndex = 3;
			lblNomeUsuario.Text = "Nome";
			lblNomeUsuario.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panelSideMenu
			// 
			panelSideMenu.BorderStyle = BorderStyle.FixedSingle;
			panelSideMenu.Controls.Add(tableLayoutPanel1);
			panelSideMenu.Dock = DockStyle.Left;
			panelSideMenu.Location = new Point(10, 10);
			panelSideMenu.Name = "panelSideMenu";
			panelSideMenu.Padding = new Padding(10);
			panelSideMenu.Size = new Size(110, 430);
			panelSideMenu.TabIndex = 3;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(btnSair, 0, 4);
			tableLayoutPanel1.Controls.Add(btnListar, 0, 3);
			tableLayoutPanel1.Controls.Add(btnDeletar, 0, 2);
			tableLayoutPanel1.Controls.Add(btnAtualizar, 0, 1);
			tableLayoutPanel1.Controls.Add(btnCadastrar, 0, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(10, 10);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 5;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.Size = new Size(88, 408);
			tableLayoutPanel1.TabIndex = 3;
			// 
			// btnSair
			// 
			btnSair.Dock = DockStyle.Fill;
			btnSair.FlatStyle = FlatStyle.Flat;
			btnSair.Location = new Point(3, 327);
			btnSair.Name = "btnSair";
			btnSair.Size = new Size(82, 78);
			btnSair.TabIndex = 4;
			btnSair.Text = "Sair";
			btnSair.UseVisualStyleBackColor = true;
			// 
			// btnListar
			// 
			btnListar.Dock = DockStyle.Fill;
			btnListar.FlatStyle = FlatStyle.Flat;
			btnListar.Location = new Point(3, 246);
			btnListar.Name = "btnListar";
			btnListar.Size = new Size(82, 75);
			btnListar.TabIndex = 3;
			btnListar.Text = "Listar";
			btnListar.UseVisualStyleBackColor = true;
			// 
			// btnDeletar
			// 
			btnDeletar.Dock = DockStyle.Fill;
			btnDeletar.FlatStyle = FlatStyle.Flat;
			btnDeletar.Location = new Point(3, 165);
			btnDeletar.Name = "btnDeletar";
			btnDeletar.Size = new Size(82, 75);
			btnDeletar.TabIndex = 2;
			btnDeletar.Text = "Deletar";
			btnDeletar.UseVisualStyleBackColor = true;
			// 
			// btnAtualizar
			// 
			btnAtualizar.Dock = DockStyle.Fill;
			btnAtualizar.FlatStyle = FlatStyle.Flat;
			btnAtualizar.Location = new Point(3, 84);
			btnAtualizar.Name = "btnAtualizar";
			btnAtualizar.Size = new Size(82, 75);
			btnAtualizar.TabIndex = 1;
			btnAtualizar.Text = "Atualizar";
			btnAtualizar.UseVisualStyleBackColor = true;
			// 
			// btnCadastrar
			// 
			btnCadastrar.Dock = DockStyle.Fill;
			btnCadastrar.FlatStyle = FlatStyle.Flat;
			btnCadastrar.Location = new Point(3, 3);
			btnCadastrar.Name = "btnCadastrar";
			btnCadastrar.Size = new Size(82, 75);
			btnCadastrar.TabIndex = 0;
			btnCadastrar.Text = "Cadastrar";
			btnCadastrar.UseVisualStyleBackColor = true;
			// 
			// frmUsuario
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			ClientSize = new Size(800, 450);
			Controls.Add(panelContent);
			FormBorderStyle = FormBorderStyle.None;
			Name = "frmUsuario";
			Text = "Usuarios";
			panelContent.ResumeLayout(false);
			panelDtGrid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dtGridUsuarios).EndInit();
			panelPesquisa.ResumeLayout(false);
			tbPanelPesquisa.ResumeLayout(false);
			tbPanelPesquisa.PerformLayout();
			panelSideMenu.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panelContent;
		private Panel panelSideMenu;
		private TableLayoutPanel tableLayoutPanel1;
		private Button btnSair;
		private Button btnListar;
		private Button btnDeletar;
		private Button btnAtualizar;
		private Button btnCadastrar;
		private Panel panelDtGrid;
		private Panel panelPesquisa;
		private TableLayoutPanel tbPanelPesquisa;
		private Button btnPesquisar;
		private TextBox txtProcurar;
		private Label lblNomeUsuario;
		private DataGridView dtGridUsuarios;
	}
}