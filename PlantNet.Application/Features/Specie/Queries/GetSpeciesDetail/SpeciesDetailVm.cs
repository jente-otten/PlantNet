using PlantNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantNet.Application.Features.Specie.Queries.GetSpeciesDetail
{
    public class SpeciesDetailVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public int MinHumidity { get; set; }
        public int MaxHumidity { get; set; }
        public LightLevel LightLevel { get; set; }
        public Family PlantType { get; set; }
    }
}
