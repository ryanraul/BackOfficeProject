using Domain.Core.Models;

namespace Identidade.Domain.Models
{
    public class Endereco : BaseEntity
    {
        public Endereco(string cep, string uf, string cidade, string bairro, string rua, string complemento)
        {
            Cep = cep;
            Uf = uf;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            Complemento = complemento;
        }

        public string Cep { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Complemento { get; set; }
    }
}
