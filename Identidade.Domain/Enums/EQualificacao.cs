using System.ComponentModel;

namespace Identidade.Domain.Enums
{
    public enum EQualificacao
    {
        [Description("Cliente")]
        Cliente = 1,
        [Description("Fornecedor")]
        Fornecedor = 2,  
        [Description("Colaborador")]
        Colaborador = 3,
    }
}
