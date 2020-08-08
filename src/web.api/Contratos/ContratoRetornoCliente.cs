using Alterdata.Bimer.Core.Algoritmos;
using Alterdata.Bimer.Core.Modelo.Abstracoes;
using Alterdata.Bimer.Core.ValueObjects;
using Alterdata.Bimer.Core.ValueObjects.Impl;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace web.api.Contratos
{
	/// <summary>
	/// DTO para Endpoints de Clientes
	/// </summary>
	[DataContract]
	public class ContratoRetornoCliente
	{
		public ContratoRetornoCliente()
		{
			Contatos = new List<Contato>();
		}
		/// <summary>
		/// Obtém ou define Identificador do Cliente.
		/// </summary>
		[DataMember(Name = "identificador")]
		public int Identificador { get; set; }

		/// <summary>
		/// Obtém ou define o Nome do Cliente.
		/// </summary>
		[DataMember(Name = "nome")]
		public Nome Nome { get; set; }

		/// <summary>
		/// Obtém ou define o Endereço do Cliente.
		/// </summary>
		[DataMember(Name = "endereco")]
		public Endereco Endereco { get; set; }

		/// <summary>
		/// Obtém ou define os Contatos do Cliente.
		/// </summary>
		[DataMember(Name = "contatos")]
		public IList<Contato> Contatos { get; set; }

		/// <summary>
		/// Obtém ou define a Data de Nascimento do Cliente.
		/// </summary>
		[DataMember(Name = "dataNascimento")]
		public DateTime DataNascimento { get; set; }

		/// <summary>
		/// Obtém ou define o Login do Cliente.
		/// </summary>
		[DataMember(Name = "login")]
		public Login Login { get; set; }

		/// <summary>
		/// Obtém ou define a Senha do Cliente.
		/// </summary>
		[DataMember(Name = "senha")]
		public Senha Senha { get; set; }

		/// <summary>
		/// Obtém ou define o Role do Cliente.
		/// </summary>
		[DataMember(Name = "role")]
		public Role Role { get; set; }
	}
}
