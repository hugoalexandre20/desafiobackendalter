namespace Alterdata.Bimer.WebAPI.IoC
{
	using Alterdata.Bimer.Core.Modelo;
	using Alterdata.Bimer.Core.Repositorio;
	using Alterdata.Bimer.Core.Repositorio.Impl;
	using Alterdata.Bimer.Core.Repository.Impl;
	using Alterdata.Bimer.Core.Services.Impl;
	using Alterdata.Bimer.Core.Servico;
	using Alterdata.Bimer.Core.Servico.Impl;
	using Alterdata.Bimer.WebAPI.Contratos;
	using Alterdata.Bimer.WebAPI.ServicoAplicacao;
	using Alterdata.Bimer.WebAPI.ServicoAplicacao.Impl;
	using Microsoft.Extensions.DependencyInjection;
	using web.api.Contratos;
	using web.api.ServicoAplicacao.Impl;

	public static class Configuracao
	{
		public static void InjetarDependenciasCore(this IServiceCollection services)
		{
			services.AddScoped<IServicoAplicacao<ContratoRetornoCliente>, ServicoAplicacaoCliente>();
			services.AddScoped<IServicoAplicacao<ContratoRetornoEmpresa>, ServicoAplicacaoEmpresa>();
			services.AddScoped<IServicoDominio<Empresa>, ServicoDominioEmpresa>();
			services.AddScoped<IServicoDominio<Cliente>, ServicoDominioCliente>();
			services.AddScoped<IRepositorio<Empresa>, RepositorioEmpresa>();
			services.AddScoped<IRepositorio<Cliente>, RepositorioCliente>();
			services.AddScoped<IServicoDominio<Cliente>, ServicoDominioCliente>();
		}
	}
}