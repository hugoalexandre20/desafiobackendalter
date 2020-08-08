namespace Alterdata.Bimer.Core.Servico.Impl
{
	using System.Collections.Generic;

	using Alterdata.Bimer.Core.Modelo;
	using Alterdata.Bimer.Core.Repositorio;

	/// <summary>
	/// Implementação concreta do serviço de domínio de empresas
	/// </summary>
	public class ServicoDominioEmpresa : IServicoDominio<Empresa>
	{
		private IRepositorio<Empresa> _repositorio;

		public ServicoDominioEmpresa(IRepositorio<Empresa> repositorio)
		{
			_repositorio = repositorio;
		}

		public void Adicionar(Empresa entity)
		{
			throw new System.NotImplementedException();
		}

		public void Atualizar(Empresa entity)
		{
			throw new System.NotImplementedException();
		}

		public Empresa BuscarPorLoginESenha(Empresa entity)
		{
			throw new System.NotImplementedException();
		}

		public bool Existe(Empresa entity)
		{
			throw new System.NotImplementedException();
		}

		public string GeradorToken(Empresa entity)
		{
			throw new System.NotImplementedException();
		}

		public IEnumerable<Empresa> ObterEntidades()
		{
			return _repositorio.ObterTodos();
		}

		public void Remover(Empresa entity)
		{
			throw new System.NotImplementedException();
		}
	}
}