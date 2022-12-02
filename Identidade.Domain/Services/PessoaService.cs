using Identidade.Domain.Models;
using Identidade.Domain.Repository;
using Identidade.Domain.UoW;
using System;

namespace Identidade.Domain.Services
{
    public class PessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;
        private readonly IUnitOfWork _uow;

        public PessoaService(
            IPessoaRepository pessoaRepository,
            IUnitOfWork uow)
        {
            _pessoaRepository = pessoaRepository;
            _uow = uow;
        }

        public bool SalvarPessoa(Pessoa pessoa)
        {
            var numeroDocumentoExistente = _pessoaRepository.RecuperarPorNumeroDocumento(pessoa.NumeroDocumento) != null;

            if (numeroDocumentoExistente)
                return false;

            pessoa.DataCriacao = DateTime.Now;
            _pessoaRepository.Save(pessoa);

            return _uow.Commit();
        }

        public bool EditarPessoa(Guid id, Pessoa pessoa)
        {
            var pessoaSalva = _pessoaRepository.GetById(id);
            var numeroDocumentoExistente = _pessoaRepository.RecuperarPorNumeroDocumento(pessoa.NumeroDocumento) != null;

            if (pessoaSalva is null || numeroDocumentoExistente )
                return false;

            pessoa.DataAlteracao = DateTime.Now;
            _pessoaRepository.Update(pessoa);

            return _uow.Commit();
        }

        public bool RemoverPessoa(Guid id)
        {
            var pessoaSalva = _pessoaRepository.GetById(id);

            if (pessoaSalva is null)
                return false;

            _pessoaRepository.Remove(id);

            return _uow.Commit();
        }
    }
}
