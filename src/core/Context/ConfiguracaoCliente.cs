using Alterdata.Bimer.Core.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alterdata.Bimer.Core.Context
{
	/// <summary>
	/// Classe para renomear colunas da tabela Clientes
	/// </summary>
	public class ConfiguracaoCliente : IEntityTypeConfiguration<Cliente>
	{
		public void Configure(EntityTypeBuilder<Cliente> builder)
		{
			ConfigurarNome(builder);
			ConfigurarEndereco(builder);
			ConfigurarSenha(builder);
			ConfigurarLogin(builder);
			ConfigurarRole(builder);
		}

		private void ConfigurarNome(EntityTypeBuilder<Cliente> builder)
		{
			builder.ToTable("Clientes")
			.OwnsOne(x => x.Nome, x =>
			{
				x.Property(n => n.NomePrincipal)
						.HasColumnName("NomePrincipal")
						.IsRequired(true)
						.HasMaxLength(30);
				x.Property(n => n.Sobrenome)
						.HasColumnName("Sobrenome")
						.IsRequired(false)
						.HasMaxLength(50);
			});
		}

		private void ConfigurarRole(EntityTypeBuilder<Cliente> builder)
		{
			builder.ToTable("Clientes")
						.OwnsOne(x => x.Role, x =>
						{
							x.Property(n => n.RoleValue)
									.HasColumnName("Role")
									.IsRequired(true)
									.HasMaxLength(30);
						});

		}
		private void ConfigurarLogin(EntityTypeBuilder<Cliente> builder)
		{
			builder.ToTable("Clientes")
					.OwnsOne(x => x.Login, x =>
					{
						x.Property(n => n.LoginValue)
								.HasColumnName("Login")
								.IsRequired(true)
								.HasMaxLength(30);
					});
		}

		private void ConfigurarSenha(EntityTypeBuilder<Cliente> builder)
		{
			builder.ToTable("Clientes")
				.OwnsOne(x => x.Senha, x =>
				{
					x.Property(n => n.SenhaValue)
							.HasColumnName("Senha")
							.IsRequired(true)
							.HasMaxLength(30);
				});
		}
		private void ConfigurarEndereco(EntityTypeBuilder<Cliente> builder)
		{
			builder.ToTable("Clientes")
			.OwnsOne(x => x.Endereco, x =>
			{
				x.Property(n => n.Bairro)
						.HasColumnName("Bairro")
						.IsRequired(false)
						.HasMaxLength(30);
				x.Property(n => n.CEP)
						.HasColumnName("Cep")
						.IsRequired(true)
						.HasMaxLength(10);
				x.Property(n => n.Complemento)
						.HasColumnName("ComplementoEndereco")
						.IsRequired(false)
						.HasMaxLength(10);
				x.Property(n => n.Numero)
						.HasColumnName("NumeroEndereco")
						.IsRequired()
						.HasMaxLength(10);
				x.Property(n => n.Rua)
						.HasColumnName("Rua")
						.IsRequired(true)
						.HasMaxLength(50);
			});
		}
	}
}
