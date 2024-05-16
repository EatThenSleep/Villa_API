using FlcVilla_API.Models;
using FlcVilla_API.Models.DTO;
using System.Xml.Linq;

namespace FlcVilla_API.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villas = new List<VillaDTO>{
                new VillaDTO() { Id = 1, Name = "Bình Minh Thượng Uyển", Sqft = 100, Occupancy = 4},
                new VillaDTO() { Id = 2, Name = "Vương Quốc Ánh Sáng", Sqft = 200, Occupancy = 8},
            };
    }
}
