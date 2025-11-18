using CondoLounge.Data.Entities;

namespace CondoLounge.Data.Repositories
{
    public class CondoCondoRepository : CondoLoungeGenericGenericRepository<Condo>
    {
        public CondoCondoRepository(ApplicationDbContext db, ILogger<CondoCondoRepository> logger) : base(db, logger)
        {
        }
    }
}
