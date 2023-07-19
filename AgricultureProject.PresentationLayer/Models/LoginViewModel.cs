using System.ComponentModel.DataAnnotations;

namespace AgricultureProject.PresentationLayer.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz!")]
        public string? Username { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi giriniz!")]
        public string? Password { get; set; }
    }
}
