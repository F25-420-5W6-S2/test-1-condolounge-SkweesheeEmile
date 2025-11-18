using CondoLounge.Data.Entities;

namespace CondoLounge.Data.Interfaces
{
    public interface ICondoBuildingRepository
    {
        List<ApplicationUser> GetUsersForBuilding(int id);

        List<Condo> GetCondoForBuilding(int id);

    }
}
