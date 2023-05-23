using AutoMapper;
using MediatR;
using PlantNet.Domain.Contracts.Persistence;
using PlantNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantNet.Application.Features.Specie.Queries.GetSpeciesList
{
    public class GetSpeciesListQueryHandler : IRequestHandler<GetSpeciesListQuery, List<SpeciesListVm>>
    {

        private readonly IAsyncRepository<Domain.Entities.Species> _speciesRepository;
        private readonly IMapper _mapper;

        public GetSpeciesListQueryHandler(IAsyncRepository<Domain.Entities.Species> speciesRepository, IMapper mapper)
        {
            _speciesRepository = speciesRepository;
            _mapper = mapper;
        }

        public async Task<List<SpeciesListVm>> Handle(GetSpeciesListQuery request, CancellationToken cancellationToken)
        {
            var allSpecies = (await _speciesRepository.GetAllAsync()).ToList().OrderBy(x => x.Name);
            return _mapper.Map<List<SpeciesListVm>>(allSpecies);
        }
    }
}
