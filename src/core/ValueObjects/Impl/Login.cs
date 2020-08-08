using System;
using System.Collections.Generic;
using System.Text;

namespace Alterdata.Bimer.Core.ValueObjects.Impl
{
	/// <summary>
	/// Validação das regras de negócios de obtenção de valores de um novo Login
	/// </summary>
	public class Login : ValueObject
	{
		public Login(string login)
		{
			LoginValue = login;
		}
		public Login()
		{

		}
		/// <summary>
		/// Validação das regras de negócios de obtenção de valores de um novo Login
		/// </summary>
		public string LoginValue { get; set; }
	}
}
