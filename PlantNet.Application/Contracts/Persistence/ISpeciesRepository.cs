using PlantNet.Domain.Contracts.Persistence;
using PlantNet.Domain.Entities;

namespace PlantNet.Application.Contracts.Persistence
{
    public interface ISpeciesRepository : IAsyncRepository<Species>
    {
    }
}