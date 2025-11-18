using Microsoft.AspNetCore.Identity;

namespace CondoLounge.Data.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string Name { get; set; }

        public Condo[] Condos { get; set; }

    }
}
