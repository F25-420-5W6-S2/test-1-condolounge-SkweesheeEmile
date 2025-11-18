using CondoLounge.Data.Entities;

namespace CondoLounge.Data.Repositories
{
    public class CondoUserRepository: CondoLoungeGenericGenericRepository<ApplicationUser>
    {
        public CondoUserRepository(ApplicationDbContext db, ILogger<CondoUserRepository> logger) : base(db, logger)
        {
        }
    }
}
