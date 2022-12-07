using Microsoft.AspNetCore.Identity;

namespace NASA_for_beginners.Infrastructure.Data
{
    public class ApplicationUser : IdentityUser<string>
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public bool? IsActive { get; set; } = true;
    }
}
