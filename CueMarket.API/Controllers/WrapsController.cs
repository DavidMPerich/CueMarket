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
    public class WrapsController : ControllerBase
    {
        private readonly CueMarketDbContext dbContext;
        private readonly IWrapRepository wrapRepository;
        private readonly IMapper mapper;

        public WrapsController(CueMarketDbContext dbContext, IWrapRepository wrapRepository, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.wrapRepository = wrapRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // Get Domain Models From Database
            var wraps = await wrapRepository.GetAllAsync();

            // Return DTOs
            return Ok(mapper.Map<List<WrapDto>>(wraps));
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var wrap = await wrapRepository.GetByIdAsync(id);

            if (wrap == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<WrapDto>(wrap));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddWrapRequestDto addWrapRequestDto)
        {
            var wrap = mapper.Map<Wrap>(addWrapRequestDto);

            wrap = await wrapRepository.CreateAsync(wrap);

            var wrapDto = mapper.Map<WrapDto>(wrap);

            return CreatedAtAction(nameof(GetById), new { id = wrapDto.Id }, wrapDto);
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateWrapRequestDto updateWrapRequestDto)
        {
            var wrap = mapper.Map<Wrap>(updateWrapRequestDto);

            wrap = await wrapRepository.UpdateAsync(id, wrap);

            if (wrap == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<WrapDto>(wrap));
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var wrap = await wrapRepository.DeleteAsync(id);

            if (wrap == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<WrapDto>(wrap));
        }
    }
}
