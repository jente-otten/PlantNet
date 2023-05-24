using MediatR;
using PlantNet.Domain.Entities;

namespace PlantNet.Application.Features.Specie.Commands.CreateSpecies
{
    public class CreateSpeciesCommand : IRequest<int>
    {
        public string Name { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }

        public LightLevel LightLevel { get; set; }
        public Family PlantType { get; set; }
    }
}