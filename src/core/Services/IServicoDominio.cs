namespace Alterdata.Bimer.Core.Servico
{
	using System.Collections.Generic;

	using Alterdata.Bimer.Core.Modelo;

	/// <summary>
	/// Interface para abstração do serviço de domínio das Entidades
	/// </summary>
	public interface IServicoDominio<T>
	{
		/// <summary>
		/// Obtém as entidades.
		/// </summary>
		/// <returns>A lista com todas as entidades encontradas.</returns>
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
		/// Verifica se a entidade existe na base de dados
		/// </summary>
		/// <param name="entity">A Entidade a ser verificada.</param>
		bool Existe(T entity);

		/// <summary>
		/// Gera o Token de acesso a Entidade
		/// </summary>
		/// <param name="entity">A Entidade para criação do Token.</param>
		string GeradorToken(T entity);

		/// <summary>
		/// Retorna a Entidade existente por login e senha
		/// </summary>
		/// <param name="entity">A Entidade a ser validada.</param>
		T BuscarPorLoginESenha(T entity);
	}
}