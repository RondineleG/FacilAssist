using FacilAssist.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace FacilAssist.Core.Entities
{
    public class Cliente
    {
        public int Codigo { get; set; }

        [Required(ErrorMessage = "O Nome é de Preenchimento Obrigatório")]
        [StringLength(50, ErrorMessage = "Nome tem no mínimo 2 caracteres e no máximo 50", MinimumLength = 2)]
        public string Nome { get; set; }

        public string CPF { get; set; }

        public ESexo Sexo { get; set; }

        public ETipoCliente TipoCliente { get; set; }

        public ESituacaoCliente SituacaoCliente { get; set; }
    }
}
