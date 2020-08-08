namespace Alterdata.Bimer.WebAPI.ServicoAplicacao
{
	using System.Collections.Generic;


	/// <summary>
	/// Interface para abstração do serviço de aplicação
	/// </summary>
	public interface IServicoAplicacao<T>
	{
		/// <summary>
		/// Obtém todas as entidades cadastradas.
		/// </summary>
		/// <returns>As entidades cadastradas.</returns>
		IEnumerable<T> ObterEntidades();
		/// <summary>
		/// Adiciona uma Entidade
		/// </summary>
		/// <param name="entity">A Entidade a ser adicionada.</param>
		void Adicionar(T entity);

		/// <summary>
		/// Atualiza uma Entidade
		/// </summary>
		/// <param name="entity">A Entidade a ser atualizada.</param>
		void Atualizar(T entity);

		/// <summary>
		/// Remove uma Entidade
		/// </summary>
		/// <param name="entity">A Entidade a ser removida.</param>
		void Remover(T entity);

		/// <summary>
		/// Verifica se a entidade já existe na base de dados
		/// </summary>
		/// <param name="entity">A Entidade a ser verificada.</param>
		bool Existe(T entity);
		/// <summary>
		/// Gera o Token de Acesso
		/// </summary>
		/// <param name="entity">A Entidade A ter o Token.</param>
		string GeradorToken(T entity);

		/// <summary>
		/// Retorna a Entidade existente por login e senha
		/// </summary>
		/// <param name="entity">A Entidade a ser validada.</param>
		T BuscarPorLoginESenha(T entity);
	}
}