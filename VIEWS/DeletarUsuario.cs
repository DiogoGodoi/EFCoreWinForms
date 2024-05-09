using CONTROLE;
using MODELS;

namespace VIEWS
{
	public partial class frmDeletarUsuario : Form
	{
		mdlUsuario mdlUsuario;
		public frmDeletarUsuario(mdlUsuario usuario)
		{
			InitializeComponent();
			this.mdlUsuario = usuario;
			Load += (sender, e) => { CarregarDados(); };
			btnDeletar.Click += (sender, e) => { DeletarUsuario(); };
		}

		private void CarregarDados()
		{
			txtNome.Text = mdlUsuario.NomeUsuario;
			txtSenha.Text = mdlUsuario.Senha;
			cbNível.Text = mdlUsuario.Nivel;
		}

		private void DeletarUsuario()
		{
			try
			{
				var resposta = MessageBox.Show("Confirma a exclusão", "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (resposta == DialogResult.Yes)
				{
					ctlUsuarios ctlUsuarios = new ctlUsuarios();
					var retorno = ctlUsuarios.Deletar(mdlUsuario.Id);

					if (retorno == true)
					{
						this.Close();
						MessageBox.Show("Deletado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else
					{
						MessageBox.Show("Erro na exclusão", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Erro interno {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
