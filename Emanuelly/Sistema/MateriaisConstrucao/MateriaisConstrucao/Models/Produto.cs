using System.ComponentModel.DataAnnotations;

namespace MateriaisConstrucao.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "O Nome do produto é obrigatório.")]
        [StringLength(100)]
        [Display(Name = "Nome do Produto")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "A Marca do produto é obrigatória.")]
        [StringLength(100)]
        [Display(Name = "Marca")]
        public string? Marca { get; set; }

        [Required(ErrorMessage = "A Categoria do produto é obrigatória.")]
        [StringLength(100)]
        [Display(Name = "Categoria")]
        public string? Categoria { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "O Peso não pode ser negativo.")]
        [Display(Name = "Peso")]
        public int Peso { get; set; }

        [Required(ErrorMessage = "A Unidade de Medida é obrigatória.")]
        [AllowedValues("Kg", "m²", "L", ErrorMessage = "Selecione a Unidade de Medida.")]
        public string? UnidadeMedida { get; set; }

        [Display(Name = "Observações")]
        [DataType(DataType.MultilineText)]
        public string? Observacao { get; set; }

        [Required(ErrorMessage = "A Aplicação do produto é obrigatória.")]
        [AllowedValues("F", "A", "E", ErrorMessage = "Selecione a Aplicação.")]
        [Display(Name = "Aplicação")]
        public string? Aplicacao { get; set; }

        [Required(ErrorMessage = "O Fornecedor do produto é obrigatório.")]
        [StringLength(100)]
        [Display(Name = "Fornecedor")]
        public string? Fornecedor { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "O Estoque Atual não pode ser negativo.")]
        [Display(Name = "Estoque Atual")]
        public int EstoqueAtual { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "O Estoque Mínimo não pode ser negativo.")]
        [Display(Name = "Estoque Mínimo")]
        public int EstoqueMinimo { get; set; }


        [DataType(DataType.Date, ErrorMessage = "Informe uma data válida.")]
        [Display(Name = "Data de Validade")]
        public DateTime? DataValidade { get; set; }
    }
}
