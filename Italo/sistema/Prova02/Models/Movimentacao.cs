using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Prova02.Models
{
    public class Movimentacao
    {
        public int MovimentacaoId { get; set; }

        // Relacionamento com o Produto
        [Required(ErrorMessage = "O produto é obrigatório.")]
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }

        public Produto? Produto { get; set; }

        public string? UsuarioId { get; set; }
        public IdentityUser? Usuario { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Digite uma quantidade de válida.")]
        public int Quatidade { get; set; }

        [Required]
        [AllowedValues("E", "S", ErrorMessage = "Selecione o tipo da Movimentação entre Entradas e Saídas.")]
        [Display(Name = "Tipo de Movimentação")]
        public string? Tipo { get; set; }

    }
}
