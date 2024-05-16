using System.ComponentModel.DataAnnotations;

namespace FlcVilla_API.Models
{
    public class Villa
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreatDate { get; set; }

    }
}
