using MODELS;

namespace CONTROLE
{
	public interface Controle<T>
	{
		IEnumerable<T> Listar();
		List<mdlUsuario> ProcurarPorNome(string nome);
		mdlUsuario ProcurarPorId(int id);
		bool Cadastrar(mdlUsuario usuario);
		bool Deletar(int id);
		bool Atualizar(mdlUsuario usuario);
	}
}
