using System.ComponentModel.DataAnnotations;

namespace SalesCet97.Web.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }
        [Display(Name = "País")] //data annotation que define o nome do campo na view
        [MaxLength(50, ErrorMessage = "O campo {0} não pode ter mais de {1} caracteres.")] //data annotation que define o tamanho máximo do campo
        [Required(ErrorMessage = "O campo {0} é obrigatório.")] //data annotation que define que o campo é obrigatório
        public string? Name { get; set; }
    }
}
