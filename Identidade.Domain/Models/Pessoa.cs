using Domain.Core.Models;
using Identidade.Domain.Enums;
using System;

namespace Identidade.Domain.Models
{
    public class Pessoa : BaseEntity
    {
        public Pessoa(ETipoPessoa tipoPessoa, string numeroDocumento, string nome, string apelido, Endereco endereco, EQualificacao qualificacao)
        {
            TipoPessoa = tipoPessoa;
            NumeroDocumento = numeroDocumento;
            Nome = nome;
            Apelido = apelido;
            Endereco = endereco;
            Qualificacao = qualificacao;
        }

        public Pessoa()
        {

        }

        public ETipoPessoa TipoPessoa { get; private set; }
        public EQualificacao Qualificacao { get; private set; }
        public string NumeroDocumento { get; private set; }
        public string Nome { get; private set; }
        public string Apelido { get; private set; }
        public Endereco Endereco { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }

        public void AtualizarPessoa(ETipoPessoa tipoPessoa, string numeroDocumento, string nome, string apelido, Endereco endereco)
        {
            TipoPessoa = tipoPessoa;
            NumeroDocumento = numeroDocumento;
            Nome = nome;
            Apelido = apelido;
            Endereco = endereco;
            DataAlteracao = DateTime.Now;
        }
    }
}
