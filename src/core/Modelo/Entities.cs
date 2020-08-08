using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Alterdata.Bimer.Core.Modelo
{
  /// <summary>
	///Abstração para Entidades
	/// </summary>
	public abstract class Entities
	{
    public Entities()
    {
      Notificacoes = new List<string>();
    }
    /// <summary>
		/// Obtém ou define o identificador da empresa.
		/// </summary>
		[Key]
    public int Identificador { get; set; }
    public IList<string> Notificacoes { get; private set; }
  }
}
