using Domain.Core.Repository;
using Identidade.Domain.Models;

namespace Identidade.Domain.Repository
{
    public interface IDepartamentoRepository : IRepository<Departamento>
    {
        Departamento RecuperarPorNome(string nome);
    }
}
