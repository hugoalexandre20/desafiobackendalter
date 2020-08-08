namespace Alterdata.Bimer.WebAPI.ServicoAplicacao.Impl
{
	using System.Collections.Generic;
	using Alterdata.Bimer.WebAPI.Parsers;
	using Alterdata.Bimer.WebAPI.Contratos;
	using Alterdata.Bimer.Core.Servico;
	using Alterdata.Bimer.Core.Modelo;

	/// <summary>
	/// Implementação concreta do serviço de domínio de empresas
	/// </summary>
	public class ServicoAplicacaoEmpresa : IServicoAplicacao<ContratoRetornoEmpresa>
	{
		private IServicoDominio<Empresa> _servicoDominioEmpresa;

		public ServicoAplicacaoEmpresa(IServicoDominio<Empresa> servicoDominioEmpresa)
		{
			_servicoDominioEmpresa = servicoDominioEmpresa;
		}

		public void Adicionar(ContratoRetornoEmpresa entity)
		{
			throw new System.NotImplementedException();
		}

		public void Atualizar(ContratoRetornoEmpresa entity)
		{
			throw new System.NotImplementedException();
		}

		public ContratoRetornoEmpresa BuscarPorLoginESenha(ContratoRetornoEmpresa entity)
		{
			throw new System.NotImplementedException();
		}

		public bool Existe(ContratoRetornoEmpresa entity)
		{
			throw new System.NotImplementedException();
		}

		public string GeradorToken(ContratoRetornoEmpresa entity)
		{
			throw new System.NotImplementedException();
		}

		public IEnumerable<ContratoRetornoEmpresa> ObterEntidades()
		{
			return EmpresaParser.Converter(_servicoDominioEmpresa.ObterEntidades());
		}

		public void Remover(ContratoRetornoEmpresa entity)
		{
			throw new System.NotImplementedException();
		}
	}
}