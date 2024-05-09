using Microsoft.EntityFrameworkCore;
using MODELS;

namespace AUTENTICACAO.Repository
{
	public interface IRepository<T>
	{
		List<mdlUsuario> ProcurarPorNome(string nome);
		mdlUsuario ProcurarPorId(int id);
		bool Cadastrar(T model);
		bool Atualizar(T model);
		bool Excluir(int id);
		IEnumerable<mdlUsuario> Listar();
		mdlUsuario Autenticar(T model);	
	}
}
