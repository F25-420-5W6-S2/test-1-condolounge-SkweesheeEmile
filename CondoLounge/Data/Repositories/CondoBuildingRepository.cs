using CondoLounge.Data.Entities;
using CondoLounge.Data.Interfaces;

namespace CondoLounge.Data.Repositories
{
    public class CondoBuildingRepository : CondoLoungeGenericGenericRepository<Building>, ICondoBuildingRepository
    {
        public CondoBuildingRepository(ApplicationDbContext db, ILogger<CondoBuildingRepository> logger) : base(db, logger)
        {
        }

        public List<Condo> GetCondoForBuilding(int id)
        {
            Building b = _dbSet.First(b => b.Id == id);

            return b.Condos;
        }

        public List<ApplicationUser> GetUsersForBuilding(int id)
        {
            Building b = _dbSet.First(b => b.Id == id);

            List<ApplicationUser> Users = new List<ApplicationUser>();

            foreach (Condo c in b.Condos)
            {
                foreach (ApplicationUser u in c.Users)
                {
                    Users.Add(u);
                }
            }

            return Users;
        }
    }
}
