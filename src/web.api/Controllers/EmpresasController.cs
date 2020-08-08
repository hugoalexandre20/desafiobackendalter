namespace Alterdata.Bimer.WebAPI.Controllers
{
    using System.Collections.Generic;
    using System;
    using Alterdata.Bimer.WebAPI.Contratos;
    using Alterdata.Bimer.WebAPI.ServicoAplicacao;
    using Microsoft.AspNetCore.Mvc;
	  using Alterdata.Bimer.Core.Modelo;

	/// <summary>
	/// Controladora de Empresas
	/// </summary>
	  [ApiController]
    [Route("api")]
    public class EmpresasController : ControllerBase
    {
        private IServicoAplicacao<ContratoRetornoEmpresa> _servicoAplicacaoEmpresa;

        public EmpresasController(IServicoAplicacao<ContratoRetornoEmpresa> servicoAplicacaoEmpresa)
        {
            _servicoAplicacaoEmpresa = servicoAplicacaoEmpresa;
        }

        /// <summary>
        /// Obtém todas as empresas cadastradas.
        /// </summary>
        /// <returns>As empresas cadastradas.</returns>
        [HttpGet]
        [Route("ObterTodos")]
        public ActionResult<IEnumerable<ContratoRetornoEmpresa>> ObterTodos()
        {
            try
            {
                return Ok(_servicoAplicacaoEmpresa.ObterEntidades());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}