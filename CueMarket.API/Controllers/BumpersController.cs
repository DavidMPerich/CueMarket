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
    public class BumpersController : ControllerBase
    {
        private readonly CueMarketDbContext dbContext;
        private readonly IBumperRepository bumperRepository;
        private readonly IMapper mapper;

        public BumpersController(CueMarketDbContext dbContext, IBumperRepository bumperRepository, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.bumperRepository = bumperRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // Get Domain Models From Database
            var bumpers = await bumperRepository.GetAllAsync();

            // Return DTOs
            return Ok(mapper.Map<List<BumperDto>>(bumpers));
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var bumper = await bumperRepository.GetByIdAsync(id);

            if (bumper == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<BumperDto>(bumper));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddBumperRequestDto addBumperRequestDto)
        {
            var bumper = mapper.Map<Bumper>(addBumperRequestDto);

            bumper = await bumperRepository.CreateAsync(bumper);

            var bumperDto = mapper.Map<BumperDto>(bumper);

            return CreatedAtAction(nameof(GetById), new { id = bumperDto.Id }, bumperDto);
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateBumperRequestDto updateBumperRequestDto)
        {
            var bumper = mapper.Map<Bumper>(updateBumperRequestDto);

            bumper = await bumperRepository.UpdateAsync(id, bumper);

            if (bumper == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<BumperDto>(bumper));
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var bumper = await bumperRepository.DeleteAsync(id);

            if (bumper == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<BumperDto>(bumper));
        }
    }
}
