using Identidade.Domain.Models;
using Identidade.Domain.Repository;
using Identidade.InfraData.Context;
using Infra.Core.Repository;
using System.Linq;

namespace Identidade.InfraData.Repositories
{
    public class PessoaRepository : Repository<Pessoa>, IPessoaRepository
    {

        public PessoaRepository(IdentidadeContext context) : base(context)
        {
        }

        public Pessoa RecuperarPorNumeroDocumento(string numeroDocumento)
        {
            return DbSet
                    .Where(x => string.Compare(x.NumeroDocumento, numeroDocumento) == 0)
                    .FirstOrDefault();
        }

    }
}
