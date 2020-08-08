using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;

namespace Alterdata.Bimer.Core.ValueObjects.Impl
{
	public class Numero : ValueObject
	{

		/// <summary>
		/// Validação das regras de negócios de obtenção de valores de um novo Nome
		/// </summary>
		public Numero(int numeroValue)
		{
			NumeroValue = numeroValue;
		}
		/// <summary>
		/// Obtém o Valor do Numero
		/// </summary>
		[RegularExpression(@"\d{8,9}", ErrorMessage ="O número completo de um telefone tem 8 ou 9 números.")]
		public int NumeroValue { get;  set; }
		
	}
}
