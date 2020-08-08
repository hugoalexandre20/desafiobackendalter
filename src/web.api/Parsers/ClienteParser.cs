using Alterdata.Bimer.Core.Modelo;
using Alterdata.Bimer.WebAPI.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web.api.Contratos;

namespace web.api.Parsers
{
	/// <summary>
	/// Mapeador entre entidades e DTOs de clientes
	/// </summary>
	public static class ClienteParser
	{
		/// <summary>
		/// Converte um modelo de domínio de cliente em um DTO de cliente.
		/// </summary>
		/// <param name="cliente">O modelo a ser convertido.</param>
		/// <returns>O DTO convertido.</returns>
		public static ContratoRetornoCliente Converter(Cliente cliente)
		{
			return new ContratoRetornoCliente
			{
				Contatos = cliente.Contatos,
				Identificador = cliente.Identificador,
				Nome = cliente.Nome,
				Endereco = cliente.Endereco,
				DataNascimento = cliente.DataNascimento,
				Login = cliente.Login,
				Role = cliente.Role,
				Senha = cliente.Senha
			};
		}

		/// <summary>
		/// Converte um DTO de cliente em um modelo de domínio de cliente.
		/// </summary>
		/// <param name="cliente">O DTO a ser convertido.</param>
		/// <returns>O modelo convertido.</returns>
		public static Cliente Converter(ContratoRetornoCliente contratoRetornoCliente)
		{
			return new Cliente
			{
				Identificador = contratoRetornoCliente.Identificador,
				Contatos = contratoRetornoCliente.Contatos,
				Nome = contratoRetornoCliente.Nome,
				Endereco = contratoRetornoCliente.Endereco,
				DataNascimento = contratoRetornoCliente.DataNascimento,
				Login = contratoRetornoCliente.Login,
				Senha = contratoRetornoCliente.Senha,
				Role = contratoRetornoCliente.Role
			};
		}

		/// <summary>
		/// Converte uma lista de modelos de domínio de cliente em uma lista de DTOs de cliente.
		/// </summary>
		/// <param name="clientes">Os modelos a serem convertidos.</param>
		/// <returns>Os DTOs convertidos.</returns>
		public static IEnumerable<ContratoRetornoCliente> Converter(IEnumerable<Cliente> clientes)
		{
			return clientes.Select(cliente => Converter(cliente));
		}

		/// <summary>
		/// Converte uma lista de DTOs de cliente em uma lista de modelos de domínio de cliente.
		/// </summary>
		/// <param name="cliente">Os DTOs a serem convertidos.</param>
		/// <returns>Os modelos convertidos.</returns>
		public static IEnumerable<Cliente> Converter(List<ContratoRetornoCliente> listaContratoRetornoCliente)
		{
			return listaContratoRetornoCliente.Select(contrato => Converter(contrato));
		}
	}
}
