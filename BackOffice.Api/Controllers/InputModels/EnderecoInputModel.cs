using Identidade.Domain.Models;

namespace BackOffice.Api.Controllers.InputModels
{
    public class EnderecoInputModel
    {
        public string Cep { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Complemento { get; set; }
    }

    public static class MapEndereco
    {
        public static Endereco MapInputEnderecoToEnderecoDomain(EnderecoInputModel input)
        {
            return new Endereco(
                input.Cep,
                input.Uf,
                input.Cidade,
                input.Bairro,
                input.Rua,
                input.Complemento);
        }
    }
}
