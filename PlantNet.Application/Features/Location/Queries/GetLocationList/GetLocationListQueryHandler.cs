using AutoMapper;
using MediatR;
using PlantNet.Application.Contracts.Persistence;

namespace PlantNet.Application.Features.Location.Queries
{
    public class GetLocationListQueryHandler : IRequestHandler<GetLocationListQuery, List<LocationListVm>>
    {
        private readonly ILocationRepository _locationRepository;
        private readonly IMapper _mapper;

        public GetLocationListQueryHandler(ILocationRepository locationRepository, IMapper mapper)
        {
            _locationRepository = locationRepository;
            _mapper = mapper;
        }

        public async Task<List<LocationListVm>> Handle(GetLocationListQuery request, CancellationToken cancellationToken)
        {
            var allLocations = (await _locationRepository.GetAllAsync()).OrderBy(x => x.Name);
            return _mapper.Map<List<LocationListVm>>(allLocations);
        }
    }
}