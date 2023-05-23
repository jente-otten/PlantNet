using AutoMapper;
using MediatR;
using PlantNet.Domain.Contracts.Persistence;
using PlantNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantNet.Application.Features.Specie.Queries.GetSpeciesDetail
{
    public class GetSpeciesDetailQueryHandler : IRequestHandler<GetSpeciesDetailQuery, SpeciesDetailVm>
    {
        private readonly IAsyncRepository<PlantNet.Domain.Entities.Species> _speciesRepository;
        private readonly IMapper _mapper;

        public GetSpeciesDetailQueryHandler(IAsyncRepository<Domain.Entities.Species> speciesRepository, IMapper mapper)
        {
            _speciesRepository = speciesRepository;
            _mapper = mapper;
        }

        public async Task<SpeciesDetailVm> Handle(GetSpeciesDetailQuery request, CancellationToken cancellationToken)
        {
            var species = await _speciesRepository.GetByIdAsync(request.Id);
            return _mapper.Map<SpeciesDetailVm>(species);
        }
    }
}
