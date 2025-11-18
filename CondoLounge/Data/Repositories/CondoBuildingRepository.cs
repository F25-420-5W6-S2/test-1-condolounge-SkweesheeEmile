using CondoLounge.Data.Entities;

namespace CondoLounge.Data.Repositories
{
    public class CondoBuildingRepository : CondoLoungeGenericGenericRepository<Building>
    {
        public CondoBuildingRepository(ApplicationDbContext db, ILogger<CondoBuildingRepository> logger) : base(db, logger)
        {
        }
    }
}
