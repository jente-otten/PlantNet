using MediatR;
using PlantNet.Domain.Contracts.Persistence;
using PlantNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantNet.Application.Features.Specie.Commands.DeleteSpecies
{
    public class DeleteSpeciesCommandHandler : IRequestHandler<DeleteSpeciesCommand>
    {
        private readonly IAsyncRepository<Species> _speciesRepository;
        public async Task Handle(DeleteSpeciesCommand request, CancellationToken cancellationToken)
        {
            var speciesToDelete = await _speciesRepository.GetByIdAsync(request.Id);
            await _speciesRepository.DeleteAsync(speciesToDelete);
        }
    }
}
