using System.ComponentModel.DataAnnotations;

namespace CadastroFornecedores.Models
{
    public class FornecedorModel
    {
        [Required(ErrorMessage = "Digite o seu id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "Digite o seu Cnpj")]
        public string? Cnpj { get; set; }
        [Required(ErrorMessage = "Selecione sua especialidade")]
        public string? Especialidade { get; set; }
        


    }
}
