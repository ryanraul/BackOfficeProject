using Identidade.Domain.Enums;
using Identidade.Domain.Models;
using Identidade.Domain.Repository;
using Identidade.InfraData.Context;
using Infra.Core.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

        public Pessoa RecuperarPessoaEnderecoPorId(Guid id)
        {
            return DbSet
                    .Include(x => x.Endereco)
                    .Where(x => x.Id == id)
                    .FirstOrDefault();
        }

        public IQueryable<Pessoa> RecuperarPessoasPorQualificacao(EQualificacao eQualificacao)
        {
            return DbSet.Where(x => x.Qualificacao == eQualificacao);
        }
    }
}
