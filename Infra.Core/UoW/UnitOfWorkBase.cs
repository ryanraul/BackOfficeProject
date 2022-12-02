using Domain.Core.Repository;
using Microsoft.EntityFrameworkCore;

namespace Infra.Core.UoW
{
    public class UnitOfWorkBase<T> : IUnitOfWorkBase where T : DbContext
    {
        private T _context;
        public UnitOfWorkBase(T context)
        {
            _context = context;
        }
        public bool Commit()
        {
            var dadoSalvo = false;
            var linhasAfetadas = 0;
            while (!dadoSalvo)
            {
                try
                {
                    linhasAfetadas = _context.SaveChanges();
                    dadoSalvo = true;
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    //Todo: Log
                }
            }

            return linhasAfetadas > 0;
        }
    }
}
