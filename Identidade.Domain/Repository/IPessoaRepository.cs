using Domain.Core.Repository;
using Identidade.Domain.Models;
using System;

namespace Identidade.Domain.Repository
{
    public interface IPessoaRepository : IRepository<Pessoa>
    {
        Pessoa RecuperarPorNumeroDocumento(string numeroDocumento);
        Pessoa RecuperarPessoaEnderecoPorId(Guid id);
    }
}
