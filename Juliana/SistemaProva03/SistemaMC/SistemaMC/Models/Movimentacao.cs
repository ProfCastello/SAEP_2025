using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SistemaMC.Models
{
    public class Movimentacao
    {
        public int MovimentacaoId { get; set; }

        [Required(ErrorMessage = "O Produto é obrigatório")]
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }

        public Produto? Produto { get; set; }

        public string? UsuarioId { get; set; }
        public IdentityUser? Usuario { get; set; }

        [Required(ErrorMessage = "O Produto é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Digite uma quantidade válida")]
        public int Quantidade { get; set; }

        [Required]
        [AllowedValues("E", "S", ErrorMessage = "Selecione o Tipo de Movimentações entre Entradas ou Saidas")]
        [Display(Name = "Tipo de Movimentação")]
        public string? Tipo { get; set; } //Tipo de movimentação (ENTRADA ou SAIDA)  

    }
}
