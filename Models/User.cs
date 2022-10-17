using Microsoft.AspNetCore.Identity;

namespace ShiftWorx.Models
{
    public class User : IdentityUser
    {
        public Company Company { get; set; }
    }
}
