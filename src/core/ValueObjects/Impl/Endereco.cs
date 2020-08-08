using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;


namespace Alterdata.Bimer.Core.ValueObjects
{
	/// <summary>
	/// Validação das regras de negócios de cadastro de um novo Endereço
	/// </summary>
	
	public class Endereco : ValueObject
	{
	
		public Endereco()
		{

		}
		/// <summary>
		/// Obtém ou define o valor da Rua.
		/// </summary>
		
		public string Rua { get;  set; }
		/// <summary>
		/// Obtém ou define o valor do Numero.
		/// </summary>

		public int Numero { get;  set; }
		/// <summary>
		/// Obtém ou define o valor do Bairro.
		/// </summary>
		public string Bairro { get;  set; }
		/// <summary>
		/// Obtém ou define o valor do Complemento.
		/// </summary>
		public string Complemento { get;  set; }
		/// <summary>
		/// Obtém ou define o valor do CEP.
		/// </summary>
		public string CEP { get;  set; }

		/// <returns>O Endereço cadastrado completo.</returns>
		public override string ToString()
		{
			return $"Rua: {Rua}," + $" Nº: {Numero}," + $" Bairro: {Bairro}," + $" Complemento: {Complemento}," + $" CEP: {CEP}";
		}
	}
}
