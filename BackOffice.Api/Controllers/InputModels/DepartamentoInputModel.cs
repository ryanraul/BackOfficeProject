using Identidade.Domain.Models;
using System;

namespace BackOffice.Api.Controllers.InputModels
{
    public class DepartamentoInputModel
    {
        public string Nome { get; set; }
        public Guid ResponsavelId { get; set; }
    }

    public static class MapDepartamento
    {
        public static Departamento MapInputDepartamentoToDepartamentoDomain(DepartamentoInputModel input)
        {
            return new Departamento(
                input.Nome,
                input.ResponsavelId);
        }
    }
}
