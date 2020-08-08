using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;
using Alterdata.Bimer.Core.ValueObjects.Impl;
using Alterdata.Bimer.Core.Modelo;
using Alterdata.Bimer.Core.Modelo.Abstracoes;

namespace Alterdata.Bimer.Core.Algoritmos
{
	/// <summary>
	/// Classe de validação do tamanho de uma lista de contatos, e se tem ao menos um telefone ou um email.
	/// </summary>
	public abstract class CheckContatos
	{

		public static bool IsValid(IList<Contato> contatos, int _min)
		{

			if (contatos == null)
				return false;

			if (contatos.Count < _min)
				return false;

			var telefone = contatos.FirstOrDefault(t => typeof(Telefone).IsInstanceOfType(t));
			var email = contatos.FirstOrDefault(t => typeof(Email).IsInstanceOfType(t));

			if (telefone == null || email == null)
				return false;

			return true;
		}

	}
}
