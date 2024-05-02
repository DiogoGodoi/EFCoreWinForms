using AUTENTICACAO.Mapping;
using Microsoft.EntityFrameworkCore;
using MODELS;
namespace AUTENTICACAO
{
	public class MeuContext: DbContext
	{
        public MeuContext(){ }
        public MeuContext(DbContextOptions<MeuContext> options): base(options) { }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string conexao = "Server=PC-INFRA; Initial Catalog=Identity; Integrated Security=True; Encrypt=False;";

			optionsBuilder.UseSqlServer(conexao);
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new MappingUsuario());
		}
		public DbSet<mdlUsuario> usuarios { get; set; }
	}
}
