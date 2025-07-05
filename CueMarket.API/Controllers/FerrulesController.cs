using AutoMapper;
using CueMarket.API.Data;
using CueMarket.API.Models.Domain;
using CueMarket.API.Models.DTO;
using CueMarket.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CueMarket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FerrulesController : ControllerBase
    {
        private readonly CueMarketDbContext dbContext;
        private readonly IFerruleRepository ferruleRepository;
        private readonly IMapper mapper;

        public FerrulesController(CueMarketDbContext dbContext, IFerruleRepository ferruleRepository, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.ferruleRepository = ferruleRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // Get Domain Models From Database
            var ferrules = await ferruleRepository.GetAllAsync();

            // Return DTOs
            return Ok(mapper.Map<List<FerruleDto>>(ferrules));
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var ferrule = await ferruleRepository.GetByIdAsync(id);

            if (ferrule == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<FerruleDto>(ferrule));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddFerruleRequestDto addFerruleRequestDto)
        {
            var ferrule = mapper.Map<Ferrule>(addFerruleRequestDto);

            ferrule = await ferruleRepository.CreateAsync(ferrule);

            var ferruleDto = mapper.Map<FerruleDto>(ferrule);

            return CreatedAtAction(nameof(GetById), new { id = ferruleDto.Id }, ferruleDto);
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateFerruleRequestDto updateFerruleRequestDto)
        {
            var ferrule = mapper.Map<Ferrule>(updateFerruleRequestDto);

            ferrule = await ferruleRepository.UpdateAsync(id, ferrule);

            if (ferrule == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<FerruleDto>(ferrule));
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var ferrule = await ferruleRepository.DeleteAsync(id);

            if (ferrule == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<FerruleDto>(ferrule));
        }
    }
}
