using System.ComponentModel;

namespace Identidade.Domain.Enums
{
    public enum ETipoPessoa
    {
        [Description("Pessoa Física")]
        Fisica = 1,
        [Description("Pessoa Jurídica")]
        Juridica = 2,
    }
}
