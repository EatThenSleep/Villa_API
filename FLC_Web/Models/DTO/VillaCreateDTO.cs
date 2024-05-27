using System.ComponentModel.DataAnnotations;

namespace FLC_Web.Models.DTO
{
    public class VillaCreateDTO
    {
        [Required(ErrorMessage = "Bỏ trống cái lồn má mày à")]
        [MaxLength(30, ErrorMessage = "Địt mẹ mày nhập ít thôi! (tầm 30 thôi)")]
        public string Name { get; set; } = string.Empty;
        public string? Details { get; set; }
        [Required]
        public double Rate { get; set; }
        public int Occupancy { get; set; }
        public int Sqft { get; set; }
        public string? ImageUrl { get; set; }
        public string? Amenity { get; set; }
    }
}
