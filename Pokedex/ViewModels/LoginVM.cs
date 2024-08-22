using System.ComponentModel.DataAnnotations;

namespace Pokedex.ViewModels;

public class LoginVM
{
    [Display(Name = "Email ou Nome de Usuário", Prompt = "Email ou Nome de Usuário")]
    [Required(ErrorMessage = "Informe seu email ou nome de usuário")]
    public string Email { get; set; }   

    [Display(Name = "Senha de Acesso", Prompt = "Senha de Acesso")]
    [Required(ErrorMessage = "Informe sua Senha de Acesso")]
    public string Senha { get; set; }

    [Display(Name = "Manter Conectado?")]
    public bool Lembrar { get; set; } = false;
    
    public string UrlRetorno { get; set; }
}
