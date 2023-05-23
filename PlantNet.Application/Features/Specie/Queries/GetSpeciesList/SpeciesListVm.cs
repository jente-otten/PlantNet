using PlantNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantNet.Application.Features.Specie.Queries.GetSpeciesList
{
    public class SpeciesListVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public LightLevel LightLevel { get; set; }
        public Family PlantType { get; set; }
    }
}
