namespace VIEWS
{
	partial class frmEstoque
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
			dtGridEstoque = new DataGridView();
			panelButtons = new Panel();
			tbPanelButtons = new TableLayoutPanel();
			btnSaida = new Button();
			btnEntrada = new Button();
			tableLayoutPanel1 = new TableLayoutPanel();
			panelContent.SuspendLayout();
			panelDtGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dtGridEstoque).BeginInit();
			panelButtons.SuspendLayout();
			tbPanelButtons.SuspendLayout();
			SuspendLayout();
			// 
			// panelContent
			// 
			panelContent.Controls.Add(panelDtGrid);
			panelContent.Controls.Add(panelButtons);
			panelContent.Dock = DockStyle.Fill;
			panelContent.Location = new Point(0, 0);
			panelContent.Name = "panelContent";
			panelContent.Size = new Size(508, 342);
			panelContent.TabIndex = 0;
			// 
			// panelDtGrid
			// 
			panelDtGrid.Controls.Add(dtGridEstoque);
			panelDtGrid.Dock = DockStyle.Fill;
			panelDtGrid.Location = new Point(0, 0);
			panelDtGrid.Name = "panelDtGrid";
			panelDtGrid.Padding = new Padding(10);
			panelDtGrid.Size = new Size(508, 292);
			panelDtGrid.TabIndex = 1;
			// 
			// dtGridEstoque
			// 
			dtGridEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtGridEstoque.Dock = DockStyle.Fill;
			dtGridEstoque.Location = new Point(10, 10);
			dtGridEstoque.Name = "dtGridEstoque";
			dtGridEstoque.Size = new Size(488, 272);
			dtGridEstoque.TabIndex = 0;
			// 
			// panelButtons
			// 
			panelButtons.Controls.Add(tbPanelButtons);
			panelButtons.Dock = DockStyle.Bottom;
			panelButtons.Location = new Point(0, 292);
			panelButtons.Name = "panelButtons";
			panelButtons.Padding = new Padding(10);
			panelButtons.Size = new Size(508, 50);
			panelButtons.TabIndex = 0;
			// 
			// tbPanelButtons
			// 
			tbPanelButtons.ColumnCount = 5;
			tbPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tbPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tbPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tbPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tbPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tbPanelButtons.Controls.Add(btnSaida, 3, 0);
			tbPanelButtons.Controls.Add(btnEntrada, 1, 0);
			tbPanelButtons.Dock = DockStyle.Fill;
			tbPanelButtons.Location = new Point(10, 10);
			tbPanelButtons.Name = "tbPanelButtons";
			tbPanelButtons.RowCount = 1;
			tbPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tbPanelButtons.Size = new Size(488, 30);
			tbPanelButtons.TabIndex = 1;
			// 
			// btnSaida
			// 
			btnSaida.Dock = DockStyle.Fill;
			btnSaida.FlatStyle = FlatStyle.Flat;
			btnSaida.Location = new Point(294, 3);
			btnSaida.Name = "btnSaida";
			btnSaida.Size = new Size(91, 24);
			btnSaida.TabIndex = 0;
			btnSaida.Text = "Saida";
			btnSaida.UseVisualStyleBackColor = true;
			// 
			// btnEntrada
			// 
			btnEntrada.Dock = DockStyle.Fill;
			btnEntrada.FlatStyle = FlatStyle.Flat;
			btnEntrada.Location = new Point(100, 3);
			btnEntrada.Name = "btnEntrada";
			btnEntrada.Size = new Size(91, 24);
			btnEntrada.TabIndex = 1;
			btnEntrada.Text = "Entrada";
			btnEntrada.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 5;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Dock = DockStyle.Bottom;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Size = new Size(200, 100);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// frmEstoque
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			ClientSize = new Size(508, 342);
			Controls.Add(panelContent);
			FormBorderStyle = FormBorderStyle.None;
			Name = "frmEstoque";
			Text = "Estoque";
			panelContent.ResumeLayout(false);
			panelDtGrid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dtGridEstoque).EndInit();
			panelButtons.ResumeLayout(false);
			tbPanelButtons.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panelContent;
		private Panel panelDtGrid;
		private Panel panelButtons;
		private TableLayoutPanel tbPanelButtons;
		private TableLayoutPanel tableLayoutPanel1;
		private DataGridView dtGridEstoque;
		private Button btnSaida;
		private Button btnEntrada;
	}
}