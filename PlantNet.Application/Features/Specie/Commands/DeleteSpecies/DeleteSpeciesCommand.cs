using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantNet.Application.Features.Specie.Commands.DeleteSpecies
{
    public class DeleteSpeciesCommand : IRequest
    {
        public int Id { get; set; }
    }
}
