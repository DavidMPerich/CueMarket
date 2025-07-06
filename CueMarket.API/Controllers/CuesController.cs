using AutoMapper;
using CueMarket.API.Data;
using CueMarket.API.Models.Domain;
using CueMarket.API.Models.DTO;
using CueMarket.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CueMarket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuesController : ControllerBase
    {
        private readonly CueMarketDbContext dbContext;
        private readonly ICueRepository cueRepository;
        private readonly IMapper mapper;

        public CuesController(CueMarketDbContext dbContext, ICueRepository cueRepository, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.cueRepository = cueRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string? filterOn, [FromQuery] string? filterQuery, [FromQuery] string? sortBy, [FromQuery] bool? isAscending)
        {
            //Get Domain Models From Database
            var cues = await cueRepository.GetAllAsync(filterOn, filterQuery, sortBy, isAscending ?? true);

            //Return DTOs
            return Ok(mapper.Map<List<CueDto>>(cues));
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var cue = await cueRepository.GetByIdAsync(id);
            
            if (cue == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<CueDto>(cue));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddCueRequestDto addCueRequestDto)
        {
            var cue = mapper.Map<Cue>(addCueRequestDto);

            cue = await cueRepository.CreateAsync(cue);

            var cueDto = mapper.Map<CueDto>(cue);

            return CreatedAtAction(nameof(GetById), new { id = cueDto.Id }, cueDto);
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateCueRequestDto updateCueRequestDto)
        {
            var cue = mapper.Map<Cue>(updateCueRequestDto);

            cue = await cueRepository.UpdateAsync(id, cue);
            
            if (cue == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<CueDto>(cue));
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var cue = await cueRepository.DeleteAsync(id);

            if (cue == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<CueDto>(cue));
        }
    }
}
