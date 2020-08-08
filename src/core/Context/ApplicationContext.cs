using Alterdata.Bimer.Core.Context;
using Alterdata.Bimer.Core.Modelo;
using Alterdata.Bimer.Core.Modelo.Abstracoes;
using Alterdata.Bimer.Core.ValueObjects;
using Alterdata.Bimer.Core.ValueObjects.Impl;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web.api.Context
{/// <summary>
 /// Classe de Contexto
 /// </summary>
	public class ApplicationContext : DbContext
	{

		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
		{ }

		/// <summary>
		/// Mapeamento de Cliente no banco de dados
		/// </summary>
		public DbSet<Cliente> Clientes { get; set; }

		/// <summary>
		/// Mapeamento de Telefone no banco de dados
		/// </summary>
		public DbSet <Telefone> Telefones { get; set; }

		/// <summary>
		/// Mapeamento de Contatos no banco de dados
		/// </summary>
		public DbSet <Contato>Contatos { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			new ConfiguracaoCliente().Configure(modelBuilder.Entity<Cliente>());
			new ConfiguracaoContato().Configure(modelBuilder);
		}
	}
}
