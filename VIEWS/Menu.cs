using MODELS;

namespace VIEWS
{
	public partial class frmMenu : Form
	{
		private frmLogin frmLogin;
		private mdlUsuario usuario;
		public frmMenu(frmLogin frmLogin, mdlUsuario usuario)
		{
			InitializeComponent();

			this.StartPosition = FormStartPosition.CenterScreen;
			this.frmLogin = frmLogin;
			this.usuario = usuario;
			this.MaximizeBox = false;
			menuStripLogout.Click += (sender, e) => { frmLogin.Show(); this.Close(); };
			btnSair.Click += (sender, e) => { frmLogin.Show(); this.Close(); };
			btnEstoque.Click += (sender, e) => { AbrirTelaEstoque(); };
			FormClosed += (sender, e) => { frmLogin.Show(); };
			Load += (sender, e) => { AbrirTelaEstoque(); };
		}
		private void frmMenu_Load(object sender, EventArgs e)
		{
			lblNivel.Text = usuario.Nivel;
		}
		private void AbrirTelaEstoque()
		{
			foreach (Form form in this.MdiChildren)
			{
				if (form is frmEstoque)
				{
					MessageBox.Show("A tela de estoque já está aberta", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
			}
			frmEstoque frmEstoque = new frmEstoque();
			frmEstoque.MdiParent = this;
			frmEstoque.Show();
			frmEstoque.WindowState = FormWindowState.Maximized;
		}
	}
}
