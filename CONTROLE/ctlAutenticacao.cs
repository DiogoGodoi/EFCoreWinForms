using AUTENTICACAO.Repository;
using MODELS;

namespace CONTROLE
{
	public class ctlAutenticacao
	{
		private readonly IRepository<mdlUsuario> repository;
        public ctlAutenticacao()
        {
			repository = new RepositoryUsuarios();
        }
        public bool Autenticar(mdlUsuario _mdlUsuario)
		{
			var retorno = repository.Autenticar(_mdlUsuario);

			if(retorno == true)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
