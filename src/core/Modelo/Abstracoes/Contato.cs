using Alterdata.Bimer.Core.ValueObjects.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Alterdata.Bimer.Core.Modelo.Abstracoes
{
	public class Contato
	{
		/// <summary>
		/// Obtém ou define o Identificador do Contato.
		/// </summary>
		[Key]
		public int Identificador { get; set; }
		public Descricao Descricao { get; set; }

		public Contato()
		{

		}
	}
}
