using Identidade.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Identidade.InfraData.Context
{
    public class IdentidadeContext : DbContext
    {
        public IdentidadeContext(DbContextOptions<IdentidadeContext> options): base(options)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
    }
}
