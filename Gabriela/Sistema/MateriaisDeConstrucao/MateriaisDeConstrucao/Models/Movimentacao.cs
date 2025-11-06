using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MateriaisDeConstrucao.Models
{
    public class Movimentacao
    {
        public int MovimentacaoId { get; set; }

        //Relacionamento com o Produto
        [Required(ErrorMessage = "O produto é obrigatório.")]
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        //Relacionamneto com a tabela de usuários (Identity Framework)
        public string? UsuarioId { get; set; }
        public IdentityUser? Usuario { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Digite uma quantidade váida.")]
        public int Quantidade { get; set; }

        [Required]
        [AllowedValues("E", "S", ErrorMessage = "Selecione o Tipo de Movimentação entre Entradas(E) e Saída(S)")] //É um campo de selecionar
        [Display(Name = "Tipo de Movimentação")]
        public string? Tipo { get; set; } // Tipo de movimentação (Entrada ou Saída)

    }
}
