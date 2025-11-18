using CondoLounge.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System.Text.Json;

namespace CondoLounge.Data
{
    public class CondoSeeder
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _hosting;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public CondoSeeder(ApplicationDbContext context,
                IWebHostEnvironment hosting,
                UserManager<ApplicationUser> userManager,
                RoleManager<IdentityRole<int>> roleManager)
        {
            _db = context;
            _hosting = hosting;     //will be used to find the full path of the project 
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task Seed()
        {
            //Verify that the database exists. Hover over the method and read the documentation. 
            _db.Database.EnsureCreated();

            if (!_roleManager.Roles.Any())
            {
                await _roleManager.CreateAsync(new IdentityRole<int>("Admin"));
                await _roleManager.CreateAsync(new IdentityRole<int>("Normal"));
            }
           
            if (!_db.Buildings.Any())
            {
                var user = new ApplicationUser() { UserName = "admin@email.com", Email = "admin@email.com" };
                await _userManager.CreateAsync(user, "VerySecureAdmin45%");
                await _userManager.AddToRoleAsync(user, "Admin");

                Building defaultBuilding = new Building()
                {
                    Condos = new List<Condo>(),
                };


                Condo defaultCondo = new Condo()
                {
                    CondoNumber = 1,
                    Location = "JAC",
                    Users = new List<ApplicationUser>()
                    
                };

                user.Condos.Add(defaultCondo);
                defaultCondo.Users.Add(user);
                defaultBuilding.Condos.Add(defaultCondo);

                _db.Buildings.Add(defaultBuilding);
                _db.Condos.Add(defaultCondo);


                _db.SaveChanges();  
            }
        }
    }
}
