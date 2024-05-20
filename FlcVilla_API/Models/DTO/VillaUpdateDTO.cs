﻿using System.ComponentModel.DataAnnotations;

namespace FlcVilla_API.Models.DTO
{
    public class VillaUpdateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Bỏ trống cái lồn má mày à")]
        [MaxLength(30, ErrorMessage = "Địt mẹ mày nhập ít thôi! (tầm 30 thôi)")]
        public string Name { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
        [Required]
        public double Rate { get; set; }
        [Required]
        public int Occupancy { get; set; }
        [Required]
        public int Sqft { get; set; }
        [Required]
        public string ImageUrl { get; set; } = string.Empty;
        public string Amenity { get; set; } = string.Empty;
    }
}