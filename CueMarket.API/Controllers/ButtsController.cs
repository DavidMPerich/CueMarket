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
    public class ButtsController : ControllerBase
    {
        private readonly CueMarketDbContext dbContext;
        private readonly IButtRepository buttRepository;
        private readonly IMapper mapper;

        public ButtsController(CueMarketDbContext dbContext, IButtRepository buttRepository, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.buttRepository = buttRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // Get Domain Models From Database
            var butts = await buttRepository.GetAllAsync();

            // Return DTOs
            return Ok(mapper.Map<List<ButtDto>>(butts));
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var butt = await buttRepository.GetByIdAsync(id);

            if (butt == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<ButtDto>(butt));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddButtRequestDto addButtRequestDto)
        {
            var butt = mapper.Map<Butt>(addButtRequestDto);

            butt = await buttRepository.CreateAsync(butt);

            var buttDto = mapper.Map<ButtDto>(butt);

            return CreatedAtAction(nameof(GetById), new { id = buttDto.Id }, buttDto);
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateButtRequestDto updateButtRequestDto)
        {
            var butt = mapper.Map<Butt>(updateButtRequestDto);

            butt = await buttRepository.UpdateAsync(id, butt);

            if (butt == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<ButtDto>(butt));
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var butt = await buttRepository.DeleteAsync(id);

            if (butt == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<ButtDto>(butt));
        }
    }
}
