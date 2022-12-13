using BackOffice.Api.Controllers.InputModels;
using Identidade.Domain.Repository;
using Identidade.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackOffice.Api.Controllers
{
    [Route("api/[controller]")]
    public class DepartamentoController : Controller
    {
        private readonly DepartamentoService _departamentoService;
        private readonly IDepartamentoRepository _departamentoRepository;

        public DepartamentoController(DepartamentoService departamentoService, IDepartamentoRepository departamentoRepository)
        {
            _departamentoService = departamentoService;
            _departamentoRepository = departamentoRepository;
        }

        [HttpGet, Route("departamentos"), ProducesResponseType(typeof(string), (int)System.Net.HttpStatusCode.OK)]
        public async Task<IActionResult> RecuperarDepartamentos()
        {
            var departamentos = _departamentoRepository.GetAll();
            return Ok(new { success = true, data = departamentos });
        }

        [HttpPost, Route("salvar-departamento"), ProducesResponseType(typeof(string), (int)System.Net.HttpStatusCode.OK)]
        public async Task<IActionResult> SalvarDepartamento([FromBody] DepartamentoInputModel departamentoInputModel)
        {
            var result = _departamentoService.SalvarDepartamento(MapDepartamento.MapInputDepartamentoToDepartamentoDomain(departamentoInputModel));

            if (!result)
                return BadRequest(new { success = false });

            return Ok(new { success = true, data = departamentoInputModel });
        }
    }
}
