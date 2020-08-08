using System;
using System.Collections.Generic;
using System.Text;

namespace Alterdata.Bimer.Core.ValueObjects.Impl
{
	/// <summary>
	/// Validação das regras de negócios de obtenção de valores de uma nova Senha
	/// </summary>
	public class Senha : ValueObject
	{
		public Senha(string senha)
		{
			SenhaValue = senha;
		}
		public Senha()
		{

		}
		public string SenhaValue { get; set; }

	}
}
