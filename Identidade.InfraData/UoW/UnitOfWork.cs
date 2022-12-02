using Identidade.Domain.UoW;
using Identidade.InfraData.Context;
using Infra.Core.UoW;

namespace Identidade.InfraData.UoW
{
    public class UnitOfWork : UnitOfWorkBase<IdentidadeContext>, IUnitOfWork
    {
        public UnitOfWork(IdentidadeContext context) : base(context)
        {
        }
    }
}
