using CondoLounge.Data.Entities;
using CondoLounge.Data.Interfaces;

namespace CondoLounge.Data.Repositories
{
    public class CondoUserRepository: CondoLoungeGenericGenericRepository<ApplicationUser>, ICondoUserRepository
    {
        public CondoUserRepository(ApplicationDbContext db, ILogger<CondoUserRepository> logger) : base(db, logger)
        {
        }
    }
}
