using MediatR;

namespace PlantNet.Application.Features.Specie.Queries.GetSpeciesDetail
{
    public class GetSpeciesDetailQuery : IRequest<SpeciesDetailVm>
    {
        public int Id { get; set; }
    }
}