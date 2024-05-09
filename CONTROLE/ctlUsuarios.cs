using AUTENTICACAO.Repository;
using MODELS;

namespace CONTROLE
{
	public class ctlUsuarios: Controle<mdlUsuario>
	{
		private readonly IRepository<mdlUsuario> _repository;

        public ctlUsuarios()
        {
            _repository = new RepositoryUsuarios();
        }
        public bool Atualizar(mdlUsuario usuario)
		{
			var retorno = _repository.Atualizar(usuario);	

			if(retorno == true)
			{
				return true;
			}
			else
			{
				return false;	
			}
		}
		public bool Cadastrar(mdlUsuario usuario)
		{
			var retorno = _repository.Cadastrar(usuario);	

			if(retorno == true)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool Deletar(int id)
		{
			var retorno = _repository.Excluir(id);
			if(retorno == true)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public List<mdlUsuario> ProcurarPorNome(string nome)
		{
			var user = _repository.ProcurarPorNome(nome);

			return user;
		}
		public mdlUsuario ProcurarPorId(int id)
		{
			var user = _repository.ProcurarPorId(id);

			return user;
		}
		public IEnumerable<mdlUsuario> Listar()
		{
			var usuarios = _repository.Listar();

			if(usuarios.Count() > 0)
			{
				return usuarios;
			}
			else
			{
				return null;
			}
		}
	}
}
