using Alterdata.Bimer.Core.Modelo;
using Alterdata.Bimer.Core.Repositorio;
using Alterdata.Bimer.Core.Seguranca;
using Alterdata.Bimer.Core.Servico;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Alterdata.Bimer.Core.Services.Impl
{
	public class ServicoDominioCliente : IServicoDominio<Cliente>
	{
		private IRepositorio<Cliente> _repositorio;

		public ServicoDominioCliente(IRepositorio<Cliente> repositorio)
		{
			_repositorio = repositorio;
		}
		public void Adicionar(Cliente entity)
		{
			_repositorio.Adicionar(entity);
		}

		public void Atualizar(Cliente entity)
		{
			_repositorio.Atualizar(entity);
		}

		public Cliente BuscarPorLoginESenha(Cliente entity)
		{
			return _repositorio.BuscarPorLoginESenha(entity);
		}

		public bool Existe(Cliente entity)
		{
			return _repositorio.Existe(entity);
		}

		public string GeradorToken(Cliente entity)
		{
			return _repositorio.GeradorToken(entity);
		}

		public IEnumerable<Cliente> ObterEntidades()
		{
			return _repositorio.ObterTodos();
		}

		public void Remover(Cliente entity)
		{
			_repositorio.Remover(entity);
		}
	}
}
