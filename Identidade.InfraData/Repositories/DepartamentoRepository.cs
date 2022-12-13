using Identidade.Domain.Models;
using Identidade.Domain.Repository;
using Identidade.InfraData.Context;
using Infra.Core.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identidade.InfraData.Repositories
{
    public class DepartamentoRepository : Repository<Departamento>, IDepartamentoRepository
    {
        public DepartamentoRepository(IdentidadeContext context) : base(context)
        {
        }

        public Departamento RecuperarPorNome(string nome)
        {
            return DbSet.Where(x => x.Nome == nome).FirstOrDefault();
        }
    }
}
