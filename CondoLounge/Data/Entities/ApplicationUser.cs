using Microsoft.AspNetCore.Identity;

namespace CondoLounge.Data.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {
        public List<Condo> Condos { get; set; } = new List<Condo>();

        public List<Building> Buildings { get; set; } = new List<Building>();

    }
}
