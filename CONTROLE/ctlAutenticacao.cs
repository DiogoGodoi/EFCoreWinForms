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
        public mdlUsuario Autenticar(mdlUsuario _mdlUsuario)
		{
			var usuario = repository.Autenticar(_mdlUsuario);

			if(usuario != null)
			{
				return usuario;
			}
			else
			{
				return null;
			}
		}
	}
}
