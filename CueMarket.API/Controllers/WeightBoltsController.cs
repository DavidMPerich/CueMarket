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
    public class WeightBoltsController : ControllerBase
    {
        private readonly CueMarketDbContext dbContext;
        private readonly IWeightBoltRepository weightBoltRepository;
        private readonly IMapper mapper;

        public WeightBoltsController(CueMarketDbContext dbContext, IWeightBoltRepository weightBoltRepository, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.weightBoltRepository = weightBoltRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // Get Domain Models From Database
            var weightBolts = await weightBoltRepository.GetAllAsync();

            // Return DTOs
            return Ok(mapper.Map<List<WeightBoltDto>>(weightBolts));
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var weightBolt = await weightBoltRepository.GetByIdAsync(id);

            if (weightBolt == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<WeightBoltDto>(weightBolt));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddWeightBoltRequestDto addWeightBoltRequestDto)
        {
            var weightBolt = mapper.Map<WeightBolt>(addWeightBoltRequestDto);

            weightBolt = await weightBoltRepository.CreateAsync(weightBolt);

            var weightBoltDto = mapper.Map<WeightBoltDto>(weightBolt);

            return CreatedAtAction(nameof(GetById), new { id = weightBoltDto.Id }, weightBoltDto);
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateWeightBoltRequestDto updateWeightBoltRequestDto)
        {
            var weightBolt = mapper.Map<WeightBolt>(updateWeightBoltRequestDto);

            weightBolt = await weightBoltRepository.UpdateAsync(id, weightBolt);

            if (weightBolt == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<WeightBoltDto>(weightBolt));
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var weightBolt = await weightBoltRepository.DeleteAsync(id);

            if (weightBolt == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<WeightBoltDto>(weightBolt));
        }
    }
}