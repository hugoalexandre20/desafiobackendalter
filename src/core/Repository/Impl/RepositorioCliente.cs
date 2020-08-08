using Alterdata.Bimer.Core.Modelo;
using Alterdata.Bimer.Core.Repositorio;
using Alterdata.Bimer.Core.Seguranca;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using web.api.Context;

namespace Alterdata.Bimer.Core.Repository.Impl
{
	/// <summary>
	/// Implementação concreta do respositório de empresas
	/// </summary>
	public class RepositorioCliente : IRepositorio<Cliente>
	{
		private readonly ApplicationContext _context;
		public RepositorioCliente(ApplicationContext context)
		{
			_context = context;
		}

		public void Adicionar(Cliente entity)
		{
				_context.Add(entity);
				_context.SaveChanges();
		}

		public void Atualizar(Cliente entity)
		{
			_context.Update(entity);
			_context.SaveChanges();
		}

		public Cliente BuscarPorLoginESenha(Cliente entity)
		{
			return _context.Clientes.FirstOrDefault(c => (c.Login.LoginValue == entity.Login.LoginValue && c.Senha.SenhaValue == entity.Senha.SenhaValue));
		}

		public bool Existe(Cliente entity)
		{
			return _context.Clientes.Any(e => e.Identificador == entity.Identificador);
		}

		public string GeradorToken(Cliente entity)
		{
			var tokenHandler = new JwtSecurityTokenHandler();
			var key = Encoding.ASCII.GetBytes(ConfiguracaoToken.Segredo);

			var tokenDescriptor = new SecurityTokenDescriptor
			{
				Subject = new ClaimsIdentity(new Claim[]
				{
					new Claim(ClaimTypes.Name, entity.Login.LoginValue.ToString()),
					new Claim(ClaimTypes.Role, entity.Role.RoleValue.ToString())
				}),
				Expires = DateTime.UtcNow.AddDays(2),
				SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
			};
			var token = tokenHandler.CreateToken(tokenDescriptor);
			return tokenHandler.WriteToken(token);
		}

		public IEnumerable<Cliente> ObterTodos()
		{
				return _context.Clientes.Include(c => c.Contatos);
		}

		public void Remover(Cliente entity)
		{
				_context.Clientes.Remove(entity);
				_context.SaveChanges();
		}
	}
}
