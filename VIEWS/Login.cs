using CONTROLE;
using MODELS;

namespace VIEWS
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
			btnSair.Click += (sender, e) => { Sair(); };
			toolMenuSair.Click += (sender, e) => { Sair(); };
		}
		private void Sair()
		{
			Close();
		}
		private bool Autenticar()
		{

			mdlUsuario _mdlUsuario = new mdlUsuario();
			ctlAutenticacao _ctrlAutenticacao = new ctlAutenticacao();

			try
			{
				if (String.IsNullOrEmpty(txtUsuario.Text))
				{
					MessageBox.Show("Por favor insira o nome de usuário", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return false;	
				}
				else if (String.IsNullOrEmpty(txtSenha.Text))
				{
					MessageBox.Show("Por favor insira a senha", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return false;
				}
				else
				{
					_mdlUsuario.NomeUsuario = txtUsuario.Text;
					_mdlUsuario.Senha = txtSenha.Text;

					var retorno = _ctrlAutenticacao.Autenticar(_mdlUsuario);

					if (retorno == true)
					{
						return true;
					}
					else
					{
						MessageBox.Show("Falha na autenticação", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						return false;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Erro: {ex.Message}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
		private void btnEntrar_Click_1(object sender, EventArgs e)
		{
			var retorno = Autenticar();

			if(retorno == true)
			{
				frmMenu _frmMenu = new frmMenu(this);
				_frmMenu.Show();
				this.Hide();
				MessageBox.Show("Autenticado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
	}
}
