using PlantNet.Application.Contracts.Persistence;
using PlantNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantNet.Persistence.Repositories
{
    public class SpeciesRepository : BaseRepository<Species>, ISpeciesRepository
    {
        public SpeciesRepository(PlantNetDbContext dbContext) : base(dbContext)
        {
        }
    }
  
}
