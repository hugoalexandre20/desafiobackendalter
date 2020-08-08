namespace Alterdata.Bimer.Core.Repositorio
{
	using System.Collections.Generic;
	using Alterdata.Bimer.Core.Modelo;

	/// <summary>
	/// Interface para abstração do repositório de empresas
	/// </summary>    
	public interface IRepositorio<T>
	{
		/// <summary>
		/// Obtém as Entidades.
		/// </summary>
		/// <returns>A lista com todas as entidades encontradas.</returns>
		IEnumerable<T> ObterTodos();

		/// <summary>
		/// Adiciona uma Entidade ao repositório.
		/// </summary>
		/// <param name="entity">A Entidade a ser adicionada.</param>
		void Adicionar(T entity);

		/// <summary>
		/// Atualiza uma Entidade no repositório.
		/// </summary>
		/// <param name="entity">A Entidade a ser atualizada.</param>
		void Atualizar(T entity);

		/// <summary>
		/// Remove uma Entidade do repositório.
		/// </summary>
		/// <param name="entity">A Entidade a ser removida.</param>
		void Remover(T entity);

		/// <summary>
		/// Verifica se a entidade existe na base de dados
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