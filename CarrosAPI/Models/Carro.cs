using System.ComponentModel.DataAnnotations;

namespace CarrosAPI.Models;

public class Carro
{
    [Required]
    public int Id { get; internal set; }
    [Required(ErrorMessage = "A Marca do veiculo é obrigatória.")]
    public string Marca { get; set; }
    [Required(ErrorMessage = "O Modelo do veiculo é obrigatório.")]
    public string Modelo { get; set; }
    [Required(ErrorMessage = "O Ano do veiculo é obrigatório.")]
    // Erro que não conheço [MaxLength(4, ErrorMessage = "O Ano digitado é invalido.")]
    public int Ano { get; set; }
    //[MaxLength(200, ErrorMessage ="A Especificação não pode ter mais de 200 caracteres.")]
    public string Especificacoes { get; set; }
    [Required(ErrorMessage = "A Classe do veiculo é obrigatória.")]
    public string Classe { get; set; }
    
}
