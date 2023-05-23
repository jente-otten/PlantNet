using MediatR;
using PlantNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantNet.Application.Features.Specie.Queries.GetSpeciesList
{
    public class GetSpeciesListQuery : IRequest<List<SpeciesListVm>>
    {

    }
}
