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
    public class ButtSleevesController : ControllerBase
    {
        private readonly CueMarketDbContext dbContext;
        private readonly IButtSleeveRepository buttSleeveRepository;
        private readonly IMapper mapper;

        public ButtSleevesController(CueMarketDbContext dbContext, IButtSleeveRepository buttSleeveRepository, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.buttSleeveRepository = buttSleeveRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // Get Domain Models From Database
            var buttSleeves = await buttSleeveRepository.GetAllAsync();

            // Return DTOs
            return Ok(mapper.Map<List<ButtSleeveDto>>(buttSleeves));
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var buttSleeve = await buttSleeveRepository.GetByIdAsync(id);

            if (buttSleeve == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<ButtSleeveDto>(buttSleeve));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddButtSleeveRequestDto addButtSleeveRequestDto)
        {
            var buttSleeve = mapper.Map<ButtSleeve>(addButtSleeveRequestDto);

            buttSleeve = await buttSleeveRepository.CreateAsync(buttSleeve);

            var buttSleeveDto = mapper.Map<ButtSleeveDto>(buttSleeve);

            return CreatedAtAction(nameof(GetById), new { id = buttSleeveDto.Id }, buttSleeveDto);
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateButtSleeveRequestDto updateButtSleeveRequestDto)
        {
            var buttSleeve = mapper.Map<ButtSleeve>(updateButtSleeveRequestDto);

            buttSleeve = await buttSleeveRepository.UpdateAsync(id, buttSleeve);

            if (buttSleeve == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<ButtSleeveDto>(buttSleeve));
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var buttSleeve = await buttSleeveRepository.DeleteAsync(id);

            if (buttSleeve == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<ButtSleeveDto>(buttSleeve));
        }
    }
}
