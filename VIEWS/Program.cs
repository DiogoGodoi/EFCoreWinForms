using AUTENTICACAO;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using Unity;

namespace VIEWS
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.

			var container = new UnityContainer();

			container.RegisterType<MeuContext>();

			using (var context = container.Resolve<MeuContext>())
			{
				// Aplicando migrações do banco de dados
				context.Database.Migrate();
			}

			ApplicationConfiguration.Initialize();

			Application.Run(new frmLogin());
		}
	}
}