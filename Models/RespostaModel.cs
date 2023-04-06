using System.ComponentModel.DataAnnotations;

namespace enquete_asp.Models;

public class RespostaModel
{
    [Required]
    public string Nome { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public bool? Sim { get; set; }
}