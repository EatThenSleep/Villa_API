using FlcVilla_API.Models.Validation;
using System.ComponentModel.DataAnnotations;

namespace FlcVilla_API.Models.DTO
{
    public class VillaDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bỏ trống cái lồn má mày à")]
        [MaxLength(30, ErrorMessage = "Địt mẹ mày nhập ít thôi! (tầm 30 thôi)")]
        [UniqueVillaName]
        public string Name { get; set; } = string.Empty;
        public int Occupancy { get; set; }
        public int Sqft { get; set; }
    }
}
