using Domain.Core.Repository;
using Identidade.Domain.Models;

namespace Identidade.Domain.Repository
{
    public interface IPessoaRepository : IRepository<Pessoa>
    {
        Pessoa RecuperarPorNumeroDocumento(string numeroDocumento);
    }
}
