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
    public class RingsController : ControllerBase
    {
        private readonly CueMarketDbContext dbContext;
        private readonly IRingRepository ringRepository;
        private readonly IMapper mapper;

        public RingsController(CueMarketDbContext dbContext, IRingRepository ringRepository, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.ringRepository = ringRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // Get Domain Models From Database
            var rings = await ringRepository.GetAllAsync();

            // Return DTOs
            return Ok(mapper.Map<List<RingDto>>(rings));
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var ring = await ringRepository.GetByIdAsync(id);

            if (ring == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<RingDto>(ring));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddRingRequestDto addRingRequestDto)
        {
            var ring = mapper.Map<Ring>(addRingRequestDto);

            ring = await ringRepository.CreateAsync(ring);

            var ringDto = mapper.Map<RingDto>(ring);

            return CreatedAtAction(nameof(GetById), new { id = ringDto.Id }, ringDto);
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateRingRequestDto updateRingRequestDto)
        {
            var ring = mapper.Map<Ring>(updateRingRequestDto);

            ring = await ringRepository.UpdateAsync(id, ring);

            if (ring == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<RingDto>(ring));
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var ring = await ringRepository.DeleteAsync(id);

            if (ring == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<RingDto>(ring));
        }
    }
}
