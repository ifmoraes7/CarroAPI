using System.ComponentModel.DataAnnotations;

namespace CarrosAPI.Data.Dtos;

public class CreateCarroDto
{
    public string Marca { get; set; }
    [Required(ErrorMessage = "O Modelo do veiculo é obrigatório.")]
    public string Modelo { get; set; }
    [Required(ErrorMessage = "O Ano do veiculo é obrigatório.")]
    public int Ano { get; set; }
    [StringLength(200, ErrorMessage = "A Especificação não pode ter mais de 200 caracteres.")]
    public string Especificacoes { get; set; }
    [Required(ErrorMessage = "A Classe do veiculo é obrigatória.")]
    public string Classe { get; set; }
}
