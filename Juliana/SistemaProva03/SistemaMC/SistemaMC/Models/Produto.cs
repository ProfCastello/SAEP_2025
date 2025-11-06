using System.ComponentModel.DataAnnotations;

namespace SistemaMC.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "O Nome do produto é obrigatório")]
        [StringLength(100)]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O Categoria do produto é obrigatório")]
        [StringLength(100)]
        [Display(Name = "Categoria")]
        public string? Categoria { get; set; }

        [Required(ErrorMessage = "A marca do produto é obrigatório")]
        [StringLength(100)]
        [Display(Name = "Marca")]
        public string? Marca { get; set; }

        [Required(ErrorMessage = "A unidade de medida do produto é obrigatório")]
        [AllowedValues("Kg", "m^2", "l", ErrorMessage = "Selecione a unidade de medida do produto")]
        [Display(Name = "Unidade de Medida")]
        public string? UnidadeMedida { get; set; }

        [Required(ErrorMessage = "O Tipo do produto é obrigatório")]
        [AllowedValues("MV", "MSV", ErrorMessage = "Selecione o Tipo do produto")]
        [Display(Name = "Tipo")]
        public string? Tipo { get; set; }

        [Required(ErrorMessage = "A aplicação do produto é obrigatório")]
        [AllowedValues("F", "A", "E", ErrorMessage = "Selecione a aplicação do produto")]
        [Display(Name = "Aplicação")]
        public string? Aplicacao { get; set; }

        [StringLength(100)]
        [Display(Name = "Cor")]
        public string? Cor { get; set; }

        [StringLength(100)]
        [Display(Name = "Textura")]
        public string? Textura { get; set; }

        [StringLength(100)]
        [Display(Name = "Material")]
        public string? Material { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "O Estoque Atual não pode ser negativo")]
        [Display(Name = "Estoque Atual")]
        public int EstoqueAtual { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "O Estoque Mínimo não pode ser negativo")]
        [Display(Name = "Estoque Mínimo")]
        public int EstoqueMinimo { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Informe uma data válida")]
        [Display(Name = "Validade")]
        public DateTime DataValidade { get; set; }


    }
}
