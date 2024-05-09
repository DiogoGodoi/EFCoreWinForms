namespace VIEWS
{
	partial class frmDeletarUsuario
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
			panelAreaCadastro = new Panel();
			tbTitleContent = new TableLayoutPanel();
			lblTitle = new Label();
			panelContentForms = new Panel();
			tbContentForms = new TableLayoutPanel();
			txtSenha = new TextBox();
			lblNome = new Label();
			lblNível = new Label();
			lblSenha = new Label();
			txtNome = new TextBox();
			cbNível = new ComboBox();
			panelButton = new Panel();
			tbButton = new TableLayoutPanel();
			btnDeletar = new Button();
			panelContent.SuspendLayout();
			panelAreaCadastro.SuspendLayout();
			tbTitleContent.SuspendLayout();
			panelContentForms.SuspendLayout();
			tbContentForms.SuspendLayout();
			panelButton.SuspendLayout();
			tbButton.SuspendLayout();
			SuspendLayout();
			// 
			// panelContent
			// 
			panelContent.Controls.Add(panelAreaCadastro);
			panelContent.Dock = DockStyle.Fill;
			panelContent.Location = new Point(0, 0);
			panelContent.Name = "panelContent";
			panelContent.Padding = new Padding(10);
			panelContent.Size = new Size(372, 322);
			panelContent.TabIndex = 1;
			// 
			// panelAreaCadastro
			// 
			panelAreaCadastro.BorderStyle = BorderStyle.FixedSingle;
			panelAreaCadastro.Controls.Add(tbTitleContent);
			panelAreaCadastro.Controls.Add(panelContentForms);
			panelAreaCadastro.Controls.Add(panelButton);
			panelAreaCadastro.Dock = DockStyle.Fill;
			panelAreaCadastro.Location = new Point(10, 10);
			panelAreaCadastro.Name = "panelAreaCadastro";
			panelAreaCadastro.Size = new Size(352, 302);
			panelAreaCadastro.TabIndex = 0;
			// 
			// tbTitleContent
			// 
			tbTitleContent.ColumnCount = 1;
			tbTitleContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tbTitleContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tbTitleContent.Controls.Add(lblTitle, 0, 0);
			tbTitleContent.Dock = DockStyle.Fill;
			tbTitleContent.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
			tbTitleContent.Location = new Point(0, 0);
			tbTitleContent.Name = "tbTitleContent";
			tbTitleContent.Padding = new Padding(20, 10, 20, 10);
			tbTitleContent.RowCount = 1;
			tbTitleContent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tbTitleContent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tbTitleContent.Size = new Size(350, 109);
			tbTitleContent.TabIndex = 3;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.BorderStyle = BorderStyle.FixedSingle;
			lblTitle.Dock = DockStyle.Fill;
			lblTitle.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblTitle.Location = new Point(23, 10);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(304, 89);
			lblTitle.TabIndex = 0;
			lblTitle.Text = "Deletar Usuário";
			lblTitle.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panelContentForms
			// 
			panelContentForms.Controls.Add(tbContentForms);
			panelContentForms.Dock = DockStyle.Bottom;
			panelContentForms.Location = new Point(0, 109);
			panelContentForms.Name = "panelContentForms";
			panelContentForms.Padding = new Padding(20);
			panelContentForms.Size = new Size(350, 144);
			panelContentForms.TabIndex = 2;
			// 
			// tbContentForms
			// 
			tbContentForms.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
			tbContentForms.ColumnCount = 2;
			tbContentForms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.272728F));
			tbContentForms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.72727F));
			tbContentForms.Controls.Add(txtSenha, 1, 1);
			tbContentForms.Controls.Add(lblNome, 0, 0);
			tbContentForms.Controls.Add(lblNível, 0, 2);
			tbContentForms.Controls.Add(lblSenha, 0, 1);
			tbContentForms.Controls.Add(txtNome, 1, 0);
			tbContentForms.Controls.Add(cbNível, 1, 2);
			tbContentForms.Dock = DockStyle.Bottom;
			tbContentForms.Location = new Point(20, 24);
			tbContentForms.Name = "tbContentForms";
			tbContentForms.RowCount = 3;
			tbContentForms.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			tbContentForms.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			tbContentForms.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			tbContentForms.Size = new Size(310, 100);
			tbContentForms.TabIndex = 3;
			// 
			// txtSenha
			// 
			txtSenha.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			txtSenha.Enabled = false;
			txtSenha.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtSenha.Location = new Point(88, 38);
			txtSenha.Name = "txtSenha";
			txtSenha.ReadOnly = true;
			txtSenha.Size = new Size(218, 24);
			txtSenha.TabIndex = 4;
			// 
			// lblNome
			// 
			lblNome.AutoSize = true;
			lblNome.Dock = DockStyle.Fill;
			lblNome.Font = new Font("Showcard Gothic", 12F);
			lblNome.Location = new Point(4, 1);
			lblNome.Name = "lblNome";
			lblNome.Size = new Size(77, 32);
			lblNome.TabIndex = 0;
			lblNome.Text = "Nome";
			lblNome.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblNível
			// 
			lblNível.AutoSize = true;
			lblNível.Dock = DockStyle.Fill;
			lblNível.Font = new Font("Showcard Gothic", 12F);
			lblNível.Location = new Point(4, 67);
			lblNível.Name = "lblNível";
			lblNível.Size = new Size(77, 32);
			lblNível.TabIndex = 2;
			lblNível.Text = "Nível";
			lblNível.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblSenha
			// 
			lblSenha.AutoSize = true;
			lblSenha.Dock = DockStyle.Fill;
			lblSenha.Font = new Font("Showcard Gothic", 12F);
			lblSenha.Location = new Point(4, 34);
			lblSenha.Name = "lblSenha";
			lblSenha.Size = new Size(77, 32);
			lblSenha.TabIndex = 1;
			lblSenha.Text = "Senha";
			lblSenha.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txtNome
			// 
			txtNome.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			txtNome.Enabled = false;
			txtNome.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtNome.Location = new Point(88, 5);
			txtNome.Name = "txtNome";
			txtNome.ReadOnly = true;
			txtNome.Size = new Size(218, 24);
			txtNome.TabIndex = 3;
			// 
			// cbNível
			// 
			cbNível.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			cbNível.Enabled = false;
			cbNível.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			cbNível.FormattingEnabled = true;
			cbNível.Items.AddRange(new object[] { "Administrador\t", "Operador" });
			cbNível.Location = new Point(88, 70);
			cbNível.Name = "cbNível";
			cbNível.Size = new Size(218, 25);
			cbNível.Sorted = true;
			cbNível.TabIndex = 5;
			// 
			// panelButton
			// 
			panelButton.Controls.Add(tbButton);
			panelButton.Dock = DockStyle.Bottom;
			panelButton.Location = new Point(0, 253);
			panelButton.Name = "panelButton";
			panelButton.Padding = new Padding(20, 0, 20, 10);
			panelButton.Size = new Size(350, 47);
			panelButton.TabIndex = 1;
			// 
			// tbButton
			// 
			tbButton.ColumnCount = 3;
			tbButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tbButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tbButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tbButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tbButton.Controls.Add(btnDeletar, 1, 0);
			tbButton.Dock = DockStyle.Fill;
			tbButton.Location = new Point(20, 0);
			tbButton.Name = "tbButton";
			tbButton.RowCount = 1;
			tbButton.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tbButton.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tbButton.Size = new Size(310, 37);
			tbButton.TabIndex = 2;
			// 
			// btnDeletar
			// 
			btnDeletar.Dock = DockStyle.Fill;
			btnDeletar.FlatStyle = FlatStyle.Flat;
			btnDeletar.Location = new Point(106, 3);
			btnDeletar.Name = "btnDeletar";
			btnDeletar.Size = new Size(97, 31);
			btnDeletar.TabIndex = 0;
			btnDeletar.Text = "Deletar";
			btnDeletar.UseVisualStyleBackColor = true;
			// 
			// frmDeletarUsuario
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(372, 322);
			Controls.Add(panelContent);
			Name = "frmDeletarUsuario";
			Text = "DeletarUsuario";
			panelContent.ResumeLayout(false);
			panelAreaCadastro.ResumeLayout(false);
			tbTitleContent.ResumeLayout(false);
			tbTitleContent.PerformLayout();
			panelContentForms.ResumeLayout(false);
			tbContentForms.ResumeLayout(false);
			tbContentForms.PerformLayout();
			panelButton.ResumeLayout(false);
			tbButton.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panelContent;
		private Panel panelAreaCadastro;
		private TableLayoutPanel tbTitleContent;
		private Label lblTitle;
		private Panel panelContentForms;
		private TableLayoutPanel tbContentForms;
		private TextBox txtSenha;
		private Label lblNome;
		private Label lblNível;
		private Label lblSenha;
		private TextBox txtNome;
		private ComboBox cbNível;
		private Panel panelButton;
		private TableLayoutPanel tbButton;
		private Button btnDeletar;
	}
}