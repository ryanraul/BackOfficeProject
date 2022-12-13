using Domain.Core.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Identidade.Domain.Models
{
    public class Departamento : BaseEntity
    {
        public Departamento(string nome, Guid responsavelId)
        {
            Nome = nome;
            ResponsavelId = responsavelId;
        }

        public Departamento()
        {

        }

        public string Nome { get; private set; }
        [NotMapped]
        public Guid ResponsavelId { get; private set; } 
        public Pessoa Responsavel { get; private set; } 
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }

        public void AtribuirReponsavel(Pessoa responsavel)
        {
            Responsavel = responsavel;
        }
    }
}
