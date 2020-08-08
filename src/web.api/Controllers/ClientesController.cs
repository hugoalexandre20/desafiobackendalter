using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Alterdata.Bimer.WebAPI.ServicoAplicacao;
using Microsoft.AspNetCore.Mvc;
using web.api.Contratos;
using Alterdata.Bimer.Core.Algoritmos;
using Microsoft.AspNetCore.Authorization;

namespace web.api.Controllers
{
	/// <summary>
	/// Controladora de Clientes
	/// </summary>
	[Route("clientes")]
	[ApiController]
	public class ClientesController : ControllerBase
	{
		private IServicoAplicacao<ContratoRetornoCliente> _servicoAplicacaoCliente;

		public ClientesController(IServicoAplicacao<ContratoRetornoCliente> servicoAplicacaoCliente)
		{
			_servicoAplicacaoCliente = servicoAplicacaoCliente;
		}

		/// <summary>
		/// Acesso para cliente efetuar Login.
		/// </summary>
		/// <returns>Os clientes cadastrados.</returns>
		[HttpPost]
		[Route("login")]
		[AllowAnonymous]
		public ActionResult<dynamic> EfetuarLogin([FromBody] ContratoRetornoCliente cliente)
		{
			try
			{
				var clienteBd = _servicoAplicacaoCliente.BuscarPorLoginESenha(cliente);

				if (clienteBd == null)
				{
					return NotFound(new { message = "Usuario ou senhas inválidos" });
				}

				var token = _servicoAplicacaoCliente.GeradorToken(clienteBd);
				clienteBd.Senha.SenhaValue = "";

				return new
				{
					clienteBd,
					token
				};
			}

			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}

		}

		
		/// <summary>
		/// Obtém todas os clientes cadastrados somente para usuarios com ROLE de admin.
		/// </summary>
		/// <returns>Os clientes cadastrados.</returns>
		[HttpGet]
		[Route("ObterTodos")]
		[Authorize(Roles ="admin")]
		public ActionResult<IEnumerable<ContratoRetornoCliente>> ObterTodos()
		{
			try
			{
				return Ok(_servicoAplicacaoCliente.ObterEntidades());
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		/// <summary>
		/// Atualiza o cliente recebido na base de dados
		/// </summary>
		[HttpPut("{id}")]
		[Authorize]
		public ActionResult Atualizar([FromRoute] int id, [FromBody] ContratoRetornoCliente cliente)
		{
			var ok = _servicoAplicacaoCliente.Existe(cliente);
			if (!ok)
			{
				return BadRequest($"Cliente não existe: {cliente}");
			}

			ok = CheckContatos.IsValid(cliente.Contatos, 2);
			if (!ok)
			{
				return BadRequest("Cliente tem que ter no mínimo 2 contatos, sendo ao menos um Email e um Telefone");
			}
			if (!ModelState.IsValid || id != cliente.Identificador)
			{
				return BadRequest("Objeto inválido");
			}

			try
			{
				_servicoAplicacaoCliente.Atualizar(cliente);
				return Ok(cliente);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		/// <summary>
		/// Adiciona o cliente recebido na base de dados
		/// </summary>
		[HttpPost]
		[Authorize]
		public ActionResult Adicionar(ContratoRetornoCliente cliente)
		{
			var existe = _servicoAplicacaoCliente.Existe(cliente);

			if (existe)
			{
				return BadRequest("Objeto já existente");
			}
			if (!ModelState.IsValid)
			{
				return BadRequest("Objeto inválido");
			}

			try
			{
				_servicoAplicacaoCliente.Adicionar(cliente);
				return Created("Adicionar", cliente);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		/// <summary>
		/// Remove o cliente recebido na base de dados
		/// </summary>
		[HttpDelete("{id}")]
		[Authorize]
		public ActionResult Remover([FromRoute] int id, [FromBody] ContratoRetornoCliente cliente)
		{
			var existe = _servicoAplicacaoCliente.Existe(cliente);

			if (!existe)
			{
				return BadRequest("Objeto não existe na base de dados");
			}

			if (!ModelState.IsValid || id != cliente.Identificador)
			{
				return BadRequest("Objeto inválido");
			}

			try
			{
				_servicoAplicacaoCliente.Remover(cliente);
				return Accepted(cliente);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
	}
}
