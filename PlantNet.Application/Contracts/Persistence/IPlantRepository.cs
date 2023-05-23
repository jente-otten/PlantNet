using PlantNet.Domain.Contracts.Persistence;
using PlantNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantNet.Application.Contracts.Persistence
{
    public interface IPlantRepository:IAsyncRepository<Plant>
    {
    }
}
