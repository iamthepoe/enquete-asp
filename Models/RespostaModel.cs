using System.ComponentModel.DataAnnotations;

namespace enquete_asp.Models;

public class RespostaModel
{

    [Required(ErrorMessage = "O campo 'Nome' deve estar preenchido.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O campo 'Email' deve estar preenchido.")]

    [EmailAddress(ErrorMessage = "O endereço de email é inválido")]
    public string Email { get; set; }

    [Required(ErrorMessage = "O campo de resposta deve estar preenchido.")]
    public bool? Sim { get; set; }

}
