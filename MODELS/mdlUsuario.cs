namespace MODELS
{
	public class mdlUsuario
	{
		private int id { get; set; }
		private string nomeUsuario { get; set; } = string.Empty;
		private string senha { get; set; } = string.Empty;
		private string tipo { get; set; } = string.Empty;

		public int Id { get { return id; } set { id = value; } }
		public string NomeUsuario { get { return nomeUsuario; } set { nomeUsuario = value; } }
		public string Senha { get { return senha; } set { senha = value; } }
		public string Tipo { get { return tipo; } set { tipo = value; } }
	}
}
