using AutoMapper;
using PlantNet.Application.Features.Specie.Commands.CreateSpecies;
using PlantNet.Application.Features.Specie.Commands.DeleteSpecies;
using PlantNet.Application.Features.Specie.Commands.UpdateSpecies;
using PlantNet.Application.Features.Specie.Queries.GetSpeciesDetail;
using PlantNet.Application.Features.Specie.Queries.GetSpeciesList;
using PlantNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantNet.Application.Profiles
{
    public class MappingProfile: Profile
    {
        
        public MappingProfile()
        {
            CreateMap<Species, SpeciesListVm>().ReverseMap();
            CreateMap<Species, SpeciesDetailVm>().ReverseMap();
            CreateMap<Species, CreateSpeciesCommand>().ReverseMap();
            CreateMap<Species, UpdateSpeciesCommand>().ReverseMap();
            CreateMap<Species, DeleteSpeciesCommand>().ReverseMap();

        }
    }
}
