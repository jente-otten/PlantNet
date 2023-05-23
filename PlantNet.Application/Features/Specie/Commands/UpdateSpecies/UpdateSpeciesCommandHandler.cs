using AutoMapper;
using MediatR;
using PlantNet.Domain.Contracts.Persistence;
using PlantNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantNet.Application.Features.Specie.Commands.UpdateSpecies
{
    public class UpdateSpeciesCommandHandler : IRequestHandler<UpdateSpeciesCommand>
    {
        private readonly IAsyncRepository<Species> _speciesRepository;
        private readonly IMapper _mapper;

        public UpdateSpeciesCommandHandler(IMapper mapper, IAsyncRepository<Species> speciesRepository)
        {
            _mapper = mapper;
            _speciesRepository = speciesRepository;
        }
        
        public async Task Handle(UpdateSpeciesCommand request, CancellationToken cancellationToken)
        {
            var speciesToUpdate = await _speciesRepository.GetByIdAsync(request.Id);
            _mapper.Map(request, speciesToUpdate, typeof(UpdateSpeciesCommand), typeof(Species));
            await _speciesRepository.UpdateAsync(speciesToUpdate);
        }
    }
}
