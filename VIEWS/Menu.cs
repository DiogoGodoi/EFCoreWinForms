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
			btnUsuario.Click += (sender, e) => { AbrirTelaUsuarios(); };
			FormClosed += (sender, e) => { frmLogin.Show(); };
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
				else
				{
					this.Close();
				}
			}
			frmEstoque frmEstoque = new frmEstoque();
			frmEstoque.MdiParent = this;
			frmEstoque.Show();
			frmEstoque.WindowState = FormWindowState.Maximized;
		}
		private void AbrirTelaUsuarios()
		{
			foreach (Form form in this.MdiChildren)
			{
				if (form is frmUsuario)
				{
					MessageBox.Show("A tela de estoque já está aberta", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				else
				{
					form.Close();
				}
			}
			frmUsuario frmUsuario = new frmUsuario();
			frmUsuario.MdiParent = this;

			frmUsuario.FormClosed += (sender, e) =>
			{
				panelSideMenu.Visible = true;
			};

			frmUsuario.Activated += (sender, e) =>
			{
				panelSideMenu.Visible = false;
			};

			frmUsuario.Show();
			frmUsuario.WindowState = FormWindowState.Maximized;
		}
	}
}
