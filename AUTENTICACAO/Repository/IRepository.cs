using MODELS;

namespace AUTENTICACAO.Repository
{
	public interface IRepository<T>
	{
		mdlUsuario Procurar(T model);
		bool Cadastrar(T model);
		bool Atualizar(T model);
		bool Excluir(T model);
		IEnumerable<mdlUsuario> Listar();
		mdlUsuario Autenticar(T model);	
	}
}
