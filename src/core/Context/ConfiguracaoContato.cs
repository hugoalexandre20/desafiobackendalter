using Alterdata.Bimer.Core.Modelo;
using Alterdata.Bimer.Core.Modelo.Abstracoes;
using Alterdata.Bimer.Core.ValueObjects.Impl;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alterdata.Bimer.Core.Context
{
	/// <summary>
	/// Classe para renomear colunas da tabela Contatos
	/// </summary>
	public class ConfiguracaoContato 
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Telefone>().OwnsOne(x => x.Ddd).ToTable("Contatos").Property(n => n.DddValue).HasColumnName("Ddd").HasMaxLength(3);
			modelBuilder.Entity<Telefone>().OwnsOne(x => x.Descricao).ToTable("Contatos").Property(n => n.Texto).HasColumnName("Descricao").HasMaxLength(60);
			modelBuilder.Entity<Telefone>().OwnsOne(x => x.Numero).ToTable("Contatos").Property(n => n.NumeroValue).HasColumnName("NumeroTelefone").HasMaxLength(11);
			modelBuilder.Entity<Email>().OwnsOne(x => x.Descricao).ToTable("Contatos").Property(n => n.Texto).HasColumnName("Descricao").HasMaxLength(60);
			modelBuilder.Entity<Email>().OwnsOne(x => x.EnderecoEmail).ToTable("Contatos").Property(n => n.EnderecoEmailValue).HasColumnName("EnderecoEmail").HasMaxLength(60);
		}

	}
}
