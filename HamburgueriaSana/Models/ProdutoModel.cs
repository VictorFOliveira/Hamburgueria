using System.ComponentModel.DataAnnotations;

namespace HamburgueriaSana.Models
{
    public class ProdutoModel
    {
        [Key]
        public int ProdutoId { get; set; }
        [Required(ErrorMessage ="Digite o nome do produto")]
        public string Nome{ get; set; }

        [Required(ErrorMessage = "Digite o valor do produto")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal Preco { get;set; }
    }
}
