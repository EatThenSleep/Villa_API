
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlcVilla_API.Models
{
    public class Villa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
        public double Rate { get; set; }
        public int Sqft { get; set; }
        public int Occupancy { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string ImageLocalPath { get; set; } = string.Empty; // reference to WWW root
        public string Amenity { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
