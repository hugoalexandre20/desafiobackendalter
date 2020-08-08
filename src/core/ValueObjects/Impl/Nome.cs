using System;
using System.Collections.Generic;
using System.Text;

namespace Alterdata.Bimer.Core.ValueObjects.Impl
{
	/// <summary>
	/// Validação das regras de negócios de obtenção de valores de um novo Nome
	/// </summary>
	public class Nome : ValueObject
	{
		public Nome()
		{

		}
		

		/// <summary>
		/// Obtém o Nome Principal.
		/// </summary>
		public string NomePrincipal { get;  set; }

		/// <summary>
		/// Obtém o Sobrenome.
		/// </summary>
		public string Sobrenome { get;  set; }

		/// <returns>Retorna Nome e Sobrenome cadastrados.</returns>
		public override string ToString()
		{
			return $"{NomePrincipal}" + $"  {Sobrenome}";
		}

	}
}
