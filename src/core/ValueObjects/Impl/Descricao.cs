using System;
using System.Collections.Generic;
using System.Text;

namespace Alterdata.Bimer.Core.ValueObjects.Impl
{
	/// <summary>
	/// Validação das regras de negócios de obtenção de valores de uma nova Descrição
	/// </summary>
	public class Descricao
	{
		public Descricao()
		{

		}
		public Descricao(string texto)
		{
			Texto = texto;
		}
		/// <summary>
		/// Obtém o Texto da Descricao.
		/// </summary>
		public string Texto { get;  set; }

	}
}
