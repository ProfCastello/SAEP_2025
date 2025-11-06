using System.ComponentModel.DataAnnotations;

namespace Prova02.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório.")]
        [StringLength(100)]
        [Display(Name = "Nome do Produto")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O modelo do produto é obrigatória.")]
        [StringLength(100)]
        [Display(Name = "Modelo")]
        public string? Modelo { get; set; }

        [Required(ErrorMessage = "O fabricante do produto é obrigatória.")]
        [StringLength(100)]
        [Display(Name = "Fabricante")]
        public string? Fabricante { get; set; }

        [Required(ErrorMessage = "O código do produto é obrigatória.")]
        [StringLength(100)]
        [Display(Name = "Código")]
        public string? Codigo { get; set; }


        [Required(ErrorMessage = "O preço do produto é obrigatória.")]
        [Display(Name = "Preço")]
        [StringLength(100)]
        public string? Preco { get; set; }

        [Required(ErrorMessage = "A Localização do produto é obrigatória.")]
        [StringLength(100)]
        [Display(Name = "Localização")]
        public string? Localizacao { get; set; }

        [Required(ErrorMessage = "As especificações técnicas do produto é obrigatória.")]
        [StringLength(100)]
        [Display(Name = "Especificações Técnicas")]
        public string? Especificacoes { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "O Estoque Atual não pode ser negativo.")]
        [Display(Name = "Estoque Atual")]
        public int EstoqueAtual { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "O Estoque Minimo não pode ser negativo.")]
        [Display(Name = "Estoque Minimo")]
        public int EstoqueMinimo { get; set; }

    }
}
