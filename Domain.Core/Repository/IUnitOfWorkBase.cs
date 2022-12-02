using System.Threading.Tasks;

namespace Domain.Core.Repository
{
    public interface IUnitOfWorkBase
    {
        bool Commit();
    }
}
