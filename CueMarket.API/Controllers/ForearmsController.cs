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
    public class ForearmsController : ControllerBase
    {
        private readonly CueMarketDbContext dbContext;
        private readonly IForearmRepository forearmRepository;
        private readonly IMapper mapper;

        public ForearmsController(CueMarketDbContext dbContext, IForearmRepository forearmRepository, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.forearmRepository = forearmRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // Get Domain Models From Database
            var forearms = await forearmRepository.GetAllAsync();

            // Return DTOs
            return Ok(mapper.Map<List<ForearmDto>>(forearms));
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var forearm = await forearmRepository.GetByIdAsync(id);

            if (forearm == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<ForearmDto>(forearm));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddForearmRequestDto addForearmRequestDto)
        {
            var forearm = mapper.Map<Forearm>(addForearmRequestDto);

            forearm = await forearmRepository.CreateAsync(forearm);

            var forearmDto = mapper.Map<ForearmDto>(forearm);

            return CreatedAtAction(nameof(GetById), new { id = forearmDto.Id }, forearmDto);
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateForearmRequestDto updateForearmRequestDto)
        {
            var forearm = mapper.Map<Forearm>(updateForearmRequestDto);

            forearm = await forearmRepository.UpdateAsync(id, forearm);

            if (forearm == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<ForearmDto>(forearm));
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var forearm = await forearmRepository.DeleteAsync(id);

            if (forearm == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<ForearmDto>(forearm));
        }
    }
}
