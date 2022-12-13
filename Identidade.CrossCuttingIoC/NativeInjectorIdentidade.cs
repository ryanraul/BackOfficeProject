using Domain.Core.Repository;
using Identidade.Domain.Repository;
using Identidade.Domain.Services;
using Identidade.Domain.UoW;
using Identidade.InfraData.Context;
using Identidade.InfraData.Repositories;
using Identidade.InfraData.UoW;
using Infra.Core.UoW;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Identidade.CrossCuttingIoC
{
    public class NativeInjectorIdentidade
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUnitOfWorkBase, UnitOfWorkBase<IdentidadeContext>>();

            services.AddScoped<PessoaService>();
            services.AddScoped<IPessoaRepository, PessoaRepository>();

            services.AddScoped<DepartamentoService>();
            services.AddScoped<IDepartamentoRepository, DepartamentoRepository>();
        }
    }
}
