using Microsoft.AspNetCore.Identity;

namespace FlcVilla_API.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
