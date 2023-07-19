using System.ComponentModel.DataAnnotations;

namespace AgricultureProject.PresentationLayer.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz!")]
        public string? Username { get; set; }
        [EmailAddress(ErrorMessage = "Lütfen geçerli bir mail adresi giriniz!")]
        [Required(ErrorMessage = "Lütfen mail giriniz!")]
        public string? Mail { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi giriniz!")]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz!")]
        [Compare("Password", ErrorMessage = "Şifreler uyumlu değil, kontrol edin!")]
        public string? PasswordConfirm { get; set; }
    }
}
