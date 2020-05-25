using System.ComponentModel.DataAnnotations;

namespace EClothing.Auth.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Nome")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage="O Campo {0} deve ter no mimimo {2} e no maximo {1} caractesres", MinimumLength = 8)]

        public string Password { get; set; }
        [Required]
        [Display(Name = "Confirmação de senha")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage="O Campo {0} deve ter no mimimo {2} e no maximo {1} caractesres", MinimumLength = 8)]
        [Compare("Password", ErrorMessage="as senha devem ser iguais")]


        public string ConfirmPassword { get; set; }

        public string ReturnUrl { get; set; }
    }
}