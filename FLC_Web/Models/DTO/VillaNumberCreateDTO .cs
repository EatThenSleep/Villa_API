using System.ComponentModel.DataAnnotations;

namespace FLC_Web.Models.DTO
{
    public class VillaNumberCreateDTO
    {
        [Required(ErrorMessage = "Không nhập à thằng mặt lồn")]
        public int VillaNo { get; set; }
        [Required(ErrorMessage = "Không chọn à thằng mặt lồn")]
        public int VillaId { get; set; }
        public string SpecialDetails { get; set; } = string.Empty;
    }
}
