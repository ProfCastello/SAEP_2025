using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MateriaisDeConstrucao.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "O Nome do produto é obrigatório.")]
        [StringLength(100)]
        [Display(Name = "Nome do Produto")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "A Categoria do produto é obrigatória.")]
        [StringLength(100)]
        [Display(Name = "Categoria")]
        public string? Categoria { get; set; }

        [StringLength(100)]
        [Display(Name = "Marca")]
        public string? Marca { get; set; }

        [StringLength(100)]
        [Display(Name = "Fornecedor")]
        public string? Fornecedor { get; set; }

        [Required(ErrorMessage = "O Estoque Atual é obrigatório.")]
        [Range(0, int.MaxValue, ErrorMessage = "O Estoque Atual não pode ser negativo.")]
        [Display(Name = "Estoque Atual")]
        public int EstoqueAtual { get; set; }

        [Required(ErrorMessage = "O Estoque Mínimo do produto é obrigatório.")]
        [Range(0, int.MaxValue, ErrorMessage = "O Estoque Mínimo não pode ser negativo.")]
        [Display(Name = "Estoque Mínimo")]
        public int EstoqueMinimo { get; set; }

        [Required(ErrorMessage = "A data de Validade do produto é obrigatória.")]
        [DataType(DataType.Date, ErrorMessage = "Informe uma data válida.")]
        [Display(Name = "Data de Validade")]
        public DateTime? DataValidade { get; set; }

        [Required(ErrorMessage = "O Tipo de Aplicação do produto é obrigatório.")]
        [AllowedValues("F", "A", "E", ErrorMessage = "Selecione o Tipo de Aplicação entre Fundação(F), Acabamento(A) e Estrutura(E)")] //É um campo de selecionar
        [Display(Name = "Tipo de Aplicação")]
        public string? Aplicacao { get; set; } // Tipo de movimentação (Entrada ou Saída)

        [Required(ErrorMessage = "O Peso ou quantidade do produto é obrigatório.")]
        [Display(Name = "Peso ou Quantidade")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Peso { get; set; }

        [Required(ErrorMessage = "A Unidade de Medida do produto é obrigatória.")]
        [AllowedValues("kg", "m", "L", ErrorMessage = "Selecione o Tipo de Aplicação entre quilos(kg), metros quadrados(m) e litros(L)")] //É um campo de selecionar
        [Display(Name = "Unidade de Medida")]
        public string? UnidadeDeMedida { get; set; } // Tipo de movimentação (Entrada ou Saída)

        [StringLength(100)]
        [Display(Name = "Descrição e Aspectos")]
        public string? Descricao { get; set; }
    }
}
