using Identidade.Domain.Enums;
using Identidade.Domain.Models;
using System;

namespace BackOffice.Api.Controllers.InputModels
{
    public class PessoaInputModel
    {
        public Guid? Id { get; set; }
        public ETipoPessoa TipoPessoa { get; set; }
        public string NumeroDocumento { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public EnderecoInputModel Endereco { get; set; }
    }

    public static class MapPessoa 
    {
        public static Pessoa MapInputPessoaToPessoaDomain(PessoaInputModel input)
        {
            return new Pessoa(
                input.Id ?? Guid.Empty,
                input.TipoPessoa,
                input.NumeroDocumento,
                input.Nome,
                input.Apelido,
                MapEndereco.MapInputEnderecoToEnderecoDomain(input.Endereco));
        }
    }
}
