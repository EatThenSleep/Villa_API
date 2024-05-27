using System.ComponentModel.DataAnnotations;

namespace FLC_Web.Models.DTO
{
    public class VillaNumberUpdateDTO
    {
        [Required]
        public int VillaNo { get; set; }
        [Required]
        public int VillaId { get; set; }
        public string SpecialDetails { get; set; } = string.Empty;
    }
}
