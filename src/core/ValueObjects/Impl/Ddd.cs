using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;

namespace Alterdata.Bimer.Core.ValueObjects.Impl
{
	/// <summary>
	/// Validação das regras de negócios de obtenção de valores de um novo DDD
	/// </summary>
	public class Ddd : ValueObject
	{
		public Ddd()
		{

		}
		public Ddd(int ddd)
		{
			DddValue = ddd;
		}
		/// <summary>
		/// Obtém o Valor do DDD
		/// </summary>
		public int DddValue { get;  set; }

	}
}
