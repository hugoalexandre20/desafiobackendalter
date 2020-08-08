using Alterdata.Bimer.Core.Algoritmos;
using Alterdata.Bimer.Core.Modelo;
using Alterdata.Bimer.Core.Modelo.Abstracoes;
using Alterdata.Bimer.Core.ValueObjects.Impl;
using NUnit.Framework;
using System.Collections.Generic;

namespace unitario
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
			CheckCountTest();
		}

		/// <summary>
		/// Teste da validação para lista de contatos dos clientes terem ao menos 1 Telefone e 1 Email.
		/// </summary>
		[Test]
		public void CheckCountTest()
		{
			var contatos = new List<Contato>();
			contatos.Add(new Telefone());
			contatos.Add(new Email());

			var ok =CheckContatos.IsValid(contatos, 2);

			Assert.IsTrue(ok);
		}
	}
}