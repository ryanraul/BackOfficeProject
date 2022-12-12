using BackOffice.Api.Controllers.InputModels;
using Identidade.Domain.Enums;
using Identidade.Domain.Repository;
using Identidade.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BackOffice.Api.Controllers
{
    [Route("api/[controller]")]
    public class PessoaController : Controller
    {
        private readonly PessoaService _pessoaService;
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaController(PessoaService pessoaService, IPessoaRepository pessoaRepository)
        {
            _pessoaService = pessoaService;
            _pessoaRepository = pessoaRepository;
        }

        [HttpGet, Route("pessoas"), ProducesResponseType(typeof(string), (int)System.Net.HttpStatusCode.OK)]
        public async Task<IActionResult> RecuperarPessoas()
        {
            var pessoas = _pessoaRepository.GetAll();
            return Ok(new { success = true, data = pessoas});
        }

        [HttpGet, Route("pessoas-qualificacao/{qualificacao}"), ProducesResponseType(typeof(string), (int)System.Net.HttpStatusCode.OK)]
        public async Task<IActionResult> RecuperarPessoasQualificacao(EQualificacao qualificacao)
        {
            var pessoas = _pessoaRepository.RecuperarPessoasPorQualificacao(qualificacao);
            return Ok(new { success = true, data = pessoas });
        }

        [HttpGet, Route("pessoas/{id}"), ProducesResponseType(typeof(string), (int)System.Net.HttpStatusCode.OK)]
        public async Task<IActionResult> RecuperaPessoa([FromRoute] Guid id)
        {
            var pessoa = _pessoaRepository.RecuperarPessoaEnderecoPorId(id);
            return Ok(new { success = true, data = pessoa });
        }


        [HttpPost, Route("salvar-pessoa"), ProducesResponseType(typeof(string), (int)System.Net.HttpStatusCode.OK)]
        public async Task<IActionResult> SalvarPessoa([FromBody] PessoaInputModel pessoaInputModel)
        {
            var result = _pessoaService.SalvarPessoa(MapPessoa.MapInputPessoaToPessoaDomain(pessoaInputModel));

            if (!result)
                return BadRequest(new { success = false });

            return Ok(new { success = true, data = pessoaInputModel });
        }

        [HttpPut, Route("editar-pessoa/{id}"), ProducesResponseType(typeof(string), (int)System.Net.HttpStatusCode.OK)]
        public async Task<IActionResult> EditarPessoa([FromRoute] Guid id, [FromBody] PessoaInputModel pessoaInputModel)
        {
            var result = _pessoaService.EditarPessoa(id, MapPessoa.MapInputPessoaToPessoaDomain(pessoaInputModel));

            if (!result)
                return BadRequest(new { success = false });

            return Ok(new { success = true, data = pessoaInputModel });
        }

        [HttpDelete, Route("remover/{id}"), ProducesResponseType(typeof(string), (int)System.Net.HttpStatusCode.OK)]
        public async Task<IActionResult> RemoverPessoa([FromRoute] Guid id)
        {
            var result = _pessoaService.RemoverPessoa(id);

            if (!result)
                return BadRequest(new { success = false });

            return Ok(new { success = true });
        }



    }
}
