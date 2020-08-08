using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Alterdata.Bimer.Core.ValueObjects.Impl
{
	public class EnderecoEmail : ValueObject
	{
		/// <summary>
		/// Validação das regras de negócios de obtenção de valores de um novo Endereço de Email
		/// </summary>
		/// 
		public EnderecoEmail()
		{

		}
		public EnderecoEmail(string value)
		{
			EnderecoEmailValue = value;
		}

		/// <summary>
		/// Obtém o Valor do DDD
		/// </summary>
		[EmailAddressAttribute]
		public string EnderecoEmailValue { get;  set; }

	}
}
