using Alterdata.Bimer.Core.Modelo;
using Alterdata.Bimer.Core.Servico;
using Alterdata.Bimer.WebAPI.ServicoAplicacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web.api.Contratos;
using web.api.Parsers;

namespace web.api.ServicoAplicacao.Impl
{
	/// <summary>
	/// Implementação concreta do serviço de domínio de Cliente
	/// </summary>
	public class ServicoAplicacaoCliente : IServicoAplicacao<ContratoRetornoCliente>
	{
		private IServicoDominio<Cliente> _servicoDominioCliente { get; set; }
		public ServicoAplicacaoCliente(IServicoDominio<Cliente> servicoDominioCliente)
		{
			_servicoDominioCliente = servicoDominioCliente;
		}

		public void Adicionar(ContratoRetornoCliente entity)
		{
			 _servicoDominioCliente.Adicionar(ClienteParser.Converter(entity));
		}

		public void Atualizar(ContratoRetornoCliente entity)
		{
			 _servicoDominioCliente.Atualizar(ClienteParser.Converter(entity));
		}

		public IEnumerable<ContratoRetornoCliente> ObterEntidades()
		{
			var listaClientes = _servicoDominioCliente.ObterEntidades();
			return ClienteParser.Converter(listaClientes);
		}

		public void Remover(ContratoRetornoCliente entity)
		{
			 _servicoDominioCliente.Remover(ClienteParser.Converter(entity));
		}

		public bool Existe(ContratoRetornoCliente entity)
		{
			return _servicoDominioCliente.Existe(ClienteParser.Converter(entity));
		}

		public string GeradorToken(ContratoRetornoCliente entity)
		{
			return _servicoDominioCliente.GeradorToken(ClienteParser.Converter(entity));
		}

		public ContratoRetornoCliente BuscarPorLoginESenha(ContratoRetornoCliente entity)
		{
			var cliente = _servicoDominioCliente.BuscarPorLoginESenha(ClienteParser.Converter(entity));
			return ClienteParser.Converter(cliente);
		}
	}
}
