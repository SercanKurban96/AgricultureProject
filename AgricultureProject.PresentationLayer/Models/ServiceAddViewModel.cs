using System.ComponentModel.DataAnnotations;

namespace AgricultureProject.PresentationLayer.Models
{
    public class ServiceAddViewModel
    {
        [Display(Name = "Başlık")]
        [Required(ErrorMessage = "Başlık boş geçilemez")]
        public string? ServiceTitle { get; set; }
        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Açıklama boş geçilemez")]
        public string? ServiceDescription { get; set; }
        [Display(Name = "Görsel")]
        [Required(ErrorMessage = "Görsel boş geçilemez")]
        public IFormFile? ServiceImageUrl { get; set; }
    }
}
