using Identidade.Domain.Models;
using Identidade.Domain.Repository;
using Identidade.Domain.UoW;
using System;

namespace Identidade.Domain.Services
{
    public class DepartamentoService
    {
        private readonly IDepartamentoRepository _departamentoRepository;
        private readonly IPessoaRepository _pessoaRepository;
        private readonly IUnitOfWork _uow;

        public DepartamentoService(IDepartamentoRepository departamentoRepository, IUnitOfWork uow, IPessoaRepository pessoaRepository)
        {
            _departamentoRepository = departamentoRepository;
            _pessoaRepository = pessoaRepository;
            _uow = uow;
        }

        public bool SalvarDepartamento(Departamento departamento)
        {
            var departamentoExistente = _departamentoRepository.RecuperarPorNome(departamento.Nome) != null;

            var responsavel = _pessoaRepository.GetById(departamento.ResponsavelId);

            if (departamentoExistente)
                return false;

            departamento.AtribuirReponsavel(responsavel);
            departamento.DataCriacao = DateTime.Now;
            _departamentoRepository.Save(departamento);

            return _uow.Commit();
        }
    }
}
