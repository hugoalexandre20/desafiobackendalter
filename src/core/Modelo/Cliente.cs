using Alterdata.Bimer.Core.Algoritmos;
using Alterdata.Bimer.Core.Modelo.Abstracoes;
using Alterdata.Bimer.Core.ValueObjects;
using Alterdata.Bimer.Core.ValueObjects.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Alterdata.Bimer.Core.Modelo
{
	public class Cliente
	{
		public Cliente()
		{
			Contatos = new List<Contato>();
		}
		/// <summary>
		/// Modelo de domínio que representa um Cliente
		/// </summary>
		public Cliente(int identificador, Nome nome, Endereco endereco, IList<Contato> contatos, DateTime dataNascimento, Login login, Senha senha, Role role)
		{
			Contatos = contatos;
			Identificador = identificador;
			Nome = nome;
			Endereco = endereco;
			DataNascimento = dataNascimento;
			Login = login;
			Senha = senha;
			Role = role;
		}

		/// <summary>
		/// Obtém ou define Identificador do Cliente.
		/// </summary>
		[Key]
		public int Identificador { get; set; }

		/// <summary>
		/// Obtém ou define o Nome do Cliente.
		/// </summary>
		public Nome Nome { get; set; }

		/// <summary>
		/// Obtém ou define o Endereço do Cliente.
		/// </summary>
		public Endereco Endereco { get; set; }

		/// <summary>
		/// Obtém ou define os Contatos do Cliente.
		/// </summary>
		public IList<Contato> Contatos { get; set; }

		/// <summary>
		/// Obtém ou define a Data de Nascimento do Cliente.
		/// </summary>
		public DateTime DataNascimento { get; set; }

		/// <summary>
		/// Obtém ou define o Login do Cliente.
		/// </summary>
		public Login Login { get; set; }

		/// <summary>
		/// Obtém ou define a Senha do Cliente.
		/// </summary>
		public Senha Senha { get; set; }

		/// <summary>
		/// Obtém ou define o Role do Cliente.
		/// </summary>
		public Role Role { get; set; }
	}
}
