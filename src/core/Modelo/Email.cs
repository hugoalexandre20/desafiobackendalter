using Alterdata.Bimer.Core.Modelo.Abstracoes;
using Alterdata.Bimer.Core.ValueObjects.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Alterdata.Bimer.Core.Modelo
{
	public class Email : Contato
	{
		/// <summary>
		/// Modelo de domínio que representa um Email
		/// </summary>
		public Email(Descricao desc, EnderecoEmail endEmail)
		{
			Descricao = desc;
			EnderecoEmail = endEmail;
		}
		public Email()
		{

		}
		/// <summary>
		/// Obtém ou define o Endereço do Email.
		/// </summary>
		public EnderecoEmail EnderecoEmail { get;  set; }

	}
}
