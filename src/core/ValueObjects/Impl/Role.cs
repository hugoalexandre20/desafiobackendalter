using System;
using System.Collections.Generic;
using System.Text;

namespace Alterdata.Bimer.Core.ValueObjects.Impl
{
	/// <summary>
	/// Validação das regras de negócios de obtenção de valores de um novo Role
	/// </summary>
	public class Role
	{
		public string RoleValue { get; set; }
		public Role()
		{

		}
		public Role(string role)
		{
			RoleValue = role;
		}
	}
}
