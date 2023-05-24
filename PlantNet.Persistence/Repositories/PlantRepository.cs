using PlantNet.Application.Contracts.Persistence;
using PlantNet.Domain.Entities;

namespace PlantNet.Persistence.Repositories
{
    public class PlantRepository : BaseRepository<Plant>, IPlantRepository
    {
        public PlantRepository(PlantNetDbContext dbContext) : base(dbContext)
        {
        }
    }
}