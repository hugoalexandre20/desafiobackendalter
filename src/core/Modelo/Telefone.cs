using Alterdata.Bimer.Core.Modelo;
using Alterdata.Bimer.Core.Modelo.Abstracoes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;

namespace Alterdata.Bimer.Core.ValueObjects.Impl
{
	/// <summary>
	/// Validação das regras de negócios de obtenção de valores de um novo Telefones
	/// </summary>
	public class Telefone : Contato
	{
		public Telefone()
		{

		}
		public Telefone(Ddd ddd, Numero numero, Descricao desc)
		{
	
			Numero = numero;
			Ddd = ddd;
			Descricao = desc;
		}

		/// <summary>
		/// Obtém o valor do Numero.
		/// </summary>
		public Numero Numero { get;  set; }

		/// <summary>
		/// Obtém o valor do DDD.
		/// </summary>
		public Ddd Ddd { get;  set; }

		/// <returns>Retorna Telefone Completo.</returns>
		public override string ToString()
		{
			return $"Telefone:({Ddd.DddValue})" + $"{Numero.NumeroValue}";
		}

	}
}
