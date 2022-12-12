using Domain.Core.Repository;
using Identidade.Domain.Enums;
using Identidade.Domain.Models;
using System;
using System.Linq;

namespace Identidade.Domain.Repository
{
    public interface IPessoaRepository : IRepository<Pessoa>
    {
        Pessoa RecuperarPorNumeroDocumento(string numeroDocumento);
        Pessoa RecuperarPessoaEnderecoPorId(Guid id);
        IQueryable<Pessoa> RecuperarPessoasPorQualificacao(EQualificacao eQualificacao);
    }
}
