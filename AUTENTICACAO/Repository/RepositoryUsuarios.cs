﻿
using Microsoft.EntityFrameworkCore;
using MODELS;

namespace AUTENTICACAO.Repository
{
	public class RepositoryUsuarios : IRepository<mdlUsuario>
	{
		private readonly MeuContext _context;
		public RepositoryUsuarios()
		{
			_context = new MeuContext();
		}
		public bool Atualizar(mdlUsuario model)
		{
			try
			{
				var usuario = _context.usuarios.FirstOrDefault(i => i.Id == model.Id);

				if (usuario == null)
				{
					return false;
				}
				else
				{
					_context.usuarios.Update(usuario);
					_context.SaveChanges();
					return true;
				}
			}
			catch (Exception ex)
			{
				return false;
				throw new Exception(ex.Message);
			}
		}
		public bool Cadastrar(mdlUsuario model)
		{
			try
			{
				_context.usuarios.Add(model);
				_context.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
				throw new Exception(ex.Message);
			}
		}
		public bool Excluir(mdlUsuario model)
		{
			try
			{
				var usuario = _context.usuarios.FirstOrDefault(i => i.Id == model.Id);
				if (usuario == null)
				{
					return false;
				}
				else
				{
					_context.usuarios.Remove(usuario);
					_context.SaveChanges();
					return true;
				}
			}
			catch (Exception ex)
			{
				return false;
				throw new Exception(ex.Message);
			}
		}
		public IEnumerable<mdlUsuario> Listar(mdlUsuario model)
		{
			try
			{
				var usuarios = _context.usuarios.ToList();

				if(usuarios.Count() > 0)
				{
					return usuarios.OrderBy(i => i.NomeUsuario);
				}
				else
				{
					return null;
				}

			}catch(Exception ex)
			{
				return null;
				throw new Exception(ex.Message);
			}
		}
		public mdlUsuario Procurar(mdlUsuario model)
		{
			try
			{
				var usuario = _context.usuarios.FirstOrDefault(i => i.Id == model.Id);

				if(usuario == null)
				{
					return null;
				}
				else
				{
					return usuario;
				}
			}catch(Exception ex)
			{
				return null;
				throw new Exception(ex.Message);
			}
		}
		public bool Autenticar(mdlUsuario model)
		{
			try
			{
				var usuario = _context.usuarios.FirstOrDefault(i => i.NomeUsuario == model.NomeUsuario && i.Senha == model.Senha);

				if(usuario != null)
				{
					return true;
				}
				else
				{
					return false;
				}

			}catch(Exception ex)
			{
				return false;
				throw new Exception(ex.Message);
			}
		}
	}
}