using CondoLounge.Data.Entities;

namespace CondoLounge.Data.Interfaces
{
    public interface ICondoBuildingRepository: ICondoLoungeGenericRepository<Building>
    {
        List<ApplicationUser> GetUsersForBuilding(int id);

        List<Condo> GetCondoForBuilding(int id);

    }
}
