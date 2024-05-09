using CONTROLE;
using MODELS;

namespace VIEWS
{
	public partial class frmCadastrarUsuario : Form
	{
		public frmCadastrarUsuario()
		{
			InitializeComponent();
			WindowState = FormWindowState.Normal;
			this.StartPosition = FormStartPosition.CenterScreen;
			txtNome.Focus();
			cbNível.SelectedIndex = 0;
			MaximizeBox = false;
			btnCadastrar.Click += (sender, e) => { CadastrarUsuario(); };
		}
		private void CadastrarUsuario()
		{
			try
			{
				if (txtNome.Text == string.Empty)
				{
					MessageBox.Show("Insira o nome de usuário", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else if (txtSenha.Text == string.Empty)
				{
					MessageBox.Show("Insire a senha", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					ctlUsuarios ctlUsuarios = new ctlUsuarios();
					mdlUsuario usuario = new mdlUsuario();

					usuario.NomeUsuario = txtNome.Text;
					usuario.Senha = txtSenha.Text;
					usuario.Nivel = cbNível.Text;

					var retorno = ctlUsuarios.Cadastrar(usuario);

					if (retorno == true)
					{
						MessageBox.Show("Cadastrado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						this.Close();
					}
					else
					{
						MessageBox.Show("Erro no cadastro", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Erro interno: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
