using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MODELS;

namespace AUTENTICACAO.Mapping
{
	public class MappingUsuario : IEntityTypeConfiguration<mdlUsuario>
	{
		public void Configure(EntityTypeBuilder<mdlUsuario> builder)
		{
			builder.ToTable("Usuarios");

			builder.Property(i => i.Id)
				.IsRequired()
				.ValueGeneratedOnAdd();

			builder.HasKey(i => i.Id).HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

			builder.Property(i => i.NomeUsuario)
				.HasColumnName("Nome")
				.HasColumnType("varchar(10)")
				.IsRequired(true);

			builder.Property(i => i.Senha)
				.HasColumnName("Senha")
				.HasColumnType("varchar(8)")
				.IsRequired(true);

			builder.Property(i => i.Tipo)
				.HasColumnName("Tipo")
				.HasColumnType("varchar(15)")
				.IsRequired(true);

			builder.HasData(new mdlUsuario { Id = 1, NomeUsuario = "Diogo", Tipo = "Administrador", Senha = "12345678" });
		}
	}
}
