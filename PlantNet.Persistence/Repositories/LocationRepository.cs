using PlantNet.Application.Contracts.Persistence;
using PlantNet.Domain.Entities;

namespace PlantNet.Persistence.Repositories
{
    public class LocationRepository : BaseRepository<Location>, ILocationRepository
    {
        public LocationRepository(PlantNetDbContext dbContext) : base(dbContext)
        {
        }
    }
}