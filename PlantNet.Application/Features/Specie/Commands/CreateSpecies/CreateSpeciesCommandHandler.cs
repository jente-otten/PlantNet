using AutoMapper;
using FluentValidation;
using MediatR;
using PlantNet.Application.Contracts.Persistence;
using PlantNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantNet.Application.Features.Specie.Commands.CreateSpecies
{
    public class CreateSpeciesCommandHandler : IRequestHandler<CreateSpeciesCommand, int>
    {
        private readonly ISpeciesRepository _speciesRepository;
        private readonly IMapper _mapper;

        public CreateSpeciesCommandHandler(ISpeciesRepository speciesRepository, IMapper mapper)
        {
            _speciesRepository = speciesRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateSpeciesCommand request, CancellationToken cancellationToken)
        {
            var species = _mapper.Map<Species>(request);
            var validator = new CreateSpeciesCommandValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Count > 0)
            {
                throw new Exceptions.ValidationException(validationResult);
            }
            species = await _speciesRepository.AddAsync(species);
            return species.Id;

        }
    }
}
