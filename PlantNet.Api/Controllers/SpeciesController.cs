using MediatR;
using Microsoft.AspNetCore.Mvc;
using PlantNet.Application.Features.Specie.Commands.CreateSpecies;
using PlantNet.Application.Features.Specie.Queries.GetSpeciesDetail;
using PlantNet.Application.Features.Specie.Queries.GetSpeciesList;

namespace PlantNet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpeciesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SpeciesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllSpecies")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<SpeciesListVm>>> GetAllSpecies()
        {
            var dtos = await _mediator.Send(new GetSpeciesListQuery());
            return Ok(dtos);
        }

        [HttpGet("{id}", Name = "GetSpeciesById")]
        public async Task<ActionResult<SpeciesDetailVm>> GetSpeciesById(int id)
        {
            var getSpeciesDetailQuery = new GetSpeciesDetailQuery() { Id = id };
            return Ok(await _mediator.Send(getSpeciesDetailQuery));
        }

        [HttpPost(Name = "AddSpecies")]
        public async Task<ActionResult<int>> Create([FromBody] CreateSpeciesCommand createSpeciesCommand)
        {
            var id = await _mediator.Send(createSpeciesCommand);
            return Ok(id);
        }
    }
}