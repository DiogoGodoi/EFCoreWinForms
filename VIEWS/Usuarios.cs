using CONTROLE;

namespace VIEWS
{
	public partial class frmUsuario : Form
	{
		public frmUsuario()
		{
			InitializeComponent();
			btnSair.Click += (sender, e) => { this.Close(); };
			btnListar.Click += (sender, e) => { ListarUsuarios(); };
			btnDeletar.Click += (sender, e) => { AbrirTelaDeletarUsuario(); };
			Load += (sender, e) => { ListarUsuarios(); };
		}
		private void ListarUsuarios()
		{
			ctlUsuarios _usuarios = new ctlUsuarios();
			var usuarios = _usuarios.Listar();
			dtGridUsuarios.DataSource = usuarios.ToList();
			dtGridUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dtGridUsuarios.Columns[2].Visible = false;
			dtGridUsuarios.Focus();
			btnCadastrar.Click += (sender, e) => { AbrirTelaCadastroUsuarios(); };
			btnPesquisar.Click += (sender, e) => { PesquisarUsuario(); };
		}
		private void AbrirTelaCadastroUsuarios()
		{
			frmCadastrarUsuario _frmCadastrarUsuario = new frmCadastrarUsuario();
			_frmCadastrarUsuario.FormClosed += (sender, e) =>
			{
				ListarUsuarios();
			};
			_frmCadastrarUsuario.Show();
		}
		private void PesquisarUsuario()
		{
			try
			{
				if (txtProcurar.Text == string.Empty)
				{
					MessageBox.Show("Digite o parâmetro da pesquisa", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					ctlUsuarios ctlUsuarios = new ctlUsuarios();

					var usuario = ctlUsuarios.ProcurarPorNome(txtProcurar.Text);

					if (usuario != null)
					{
						dtGridUsuarios.DataSource = usuario;
					}
					else
					{
						MessageBox.Show("Usuário não localizado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Erro interno {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private int SelecionarUsuarioNoGird()
		{
			if (dtGridUsuarios.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dtGridUsuarios.SelectedRows[0];

				string? id = selectedRow.Cells["Id"].Value.ToString();
				return Convert.ToInt32(id);
			}
			else
			{
				MessageBox.Show("Por favor selecione um usuário no grid", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return 0;
			}
		}
		private void AbrirTelaDeletarUsuario()
		{
			ctlUsuarios ctlUsuarios = new ctlUsuarios();
			var id = SelecionarUsuarioNoGird();
			var usuario = ctlUsuarios.ProcurarPorId(id);

			frmDeletarUsuario frmDeletarUsuario = new frmDeletarUsuario(usuario);
			frmDeletarUsuario.FormClosed += (sender, e) =>
			{
				ListarUsuarios();
			};
			frmDeletarUsuario.Show();

		}
	}
}
