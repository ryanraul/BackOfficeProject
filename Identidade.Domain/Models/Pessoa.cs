using Domain.Core.Models;
using Identidade.Domain.Enums;
using System;

namespace Identidade.Domain.Models
{
    public class Pessoa : BaseEntity
    {
        public Pessoa(Guid? id,ETipoPessoa tipoPessoa, string numeroDocumento, string nome, string apelido, Endereco endereco)
        {
            TipoPessoa = tipoPessoa;
            NumeroDocumento = numeroDocumento;
            Nome = nome;
            Apelido = apelido;
            Endereco = endereco;
        }

        public Pessoa()
        {

        }

        public ETipoPessoa TipoPessoa { get; private set; }
        public string NumeroDocumento { get; private set; }
        public string Nome { get; private set; }
        public string Apelido { get; private set; }
        public Endereco Endereco { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
