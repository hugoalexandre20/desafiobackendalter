using NUnit.Framework;
using System.Net.Http;
using System.Threading.Tasks;
using WebAPI;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;

namespace integracao
{
	/// <summary>
	/// Classe de testes de Integração
	/// </summary>

	[TestFixture]
	public class TesteIntegracao
	{

		public HttpClient Client { get; set; }
		private TestServer _server;


		[SetUp]
		public void Setup()
		{
			SetupClient();
			AutorizacaoAdminTest();
		}


		private void SetupClient()
		{
			var webHost = new WebHostBuilder().UseStartup<Startup>();
			_server = new TestServer(webHost);
			Client = _server.CreateClient();
		}
		[Test]

		/// <summary>
		/// Teste para validar acesso somente com Role de Admin.
		/// </summary>
		private async Task AutorizacaoAdminTest()
		{

			var response = await Client.GetAsync("clientes/obtertodos");
			Assert.IsTrue(response.ReasonPhrase == "Unauthorized");
		}


	}
}