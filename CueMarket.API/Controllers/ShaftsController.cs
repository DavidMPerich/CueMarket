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
    public class ShaftsController : ControllerBase
    {
        private readonly CueMarketDbContext dbContext;
        private readonly IShaftRepository shaftRepository;
        private readonly IMapper mapper;

        public ShaftsController(CueMarketDbContext dbContext, IShaftRepository shaftRepository, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.shaftRepository = shaftRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // Get Domain Models From Database
            var shafts = await shaftRepository.GetAllAsync();

            // Return DTOs
            return Ok(mapper.Map<List<ShaftDto>>(shafts));
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var shaft = await shaftRepository.GetByIdAsync(id);

            if (shaft == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<ShaftDto>(shaft));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddShaftRequestDto addShaftRequestDto)
        {
            var shaft = mapper.Map<Shaft>(addShaftRequestDto);

            shaft = await shaftRepository.CreateAsync(shaft);

            var shaftDto = mapper.Map<ShaftDto>(shaft);

            return CreatedAtAction(nameof(GetById), new { id = shaftDto.Id }, shaftDto);
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateShaftRequestDto updateShaftRequestDto)
        {
            var shaft = mapper.Map<Shaft>(updateShaftRequestDto);

            shaft = await shaftRepository.UpdateAsync(id, shaft);

            if (shaft == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<ShaftDto>(shaft));
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var shaft = await shaftRepository.DeleteAsync(id);

            if (shaft == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<ShaftDto>(shaft));
        }
    }
}
