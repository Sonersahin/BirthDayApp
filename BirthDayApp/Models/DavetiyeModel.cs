using System.ComponentModel.DataAnnotations;

namespace BirthDayApp.Models
{
    public class DavetiyeModel
    {
        [Required]
        public string Ad { get; set; }
        
        [Required]
        public string Eposta { get; set; }
        
        [Required]
        public bool? KatilmaDurumu { get; set; }
    }
}