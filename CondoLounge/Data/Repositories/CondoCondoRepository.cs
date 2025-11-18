using CondoLounge.Data.Entities;
using CondoLounge.Data.Interfaces;

namespace CondoLounge.Data.Repositories
{
    public class CondoCondoRepository : CondoLoungeGenericGenericRepository<Condo>, ICondoCondoRepository
    {
        public CondoCondoRepository(ApplicationDbContext db, ILogger<CondoCondoRepository> logger) : base(db, logger)
        {
        }
    }
}
