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
    public class TipsController : ControllerBase
    {
        private readonly CueMarketDbContext dbContext;
        private readonly ITipRepository tipRepository;
        private readonly IMapper mapper;

        public TipsController(CueMarketDbContext dbContext, ITipRepository tipRepository, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.tipRepository = tipRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // Get Domain Models From Database
            var tips = await tipRepository.GetAllAsync();

            // Return DTOs
            return Ok(mapper.Map<List<TipDto>>(tips));
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var tip = await tipRepository.GetByIdAsync(id);

            if (tip == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<TipDto>(tip));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddTipRequestDto addTipRequestDto)
        {
            var tip = mapper.Map<Tip>(addTipRequestDto);

            tip = await tipRepository.CreateAsync(tip);

            var tipDto = mapper.Map<TipDto>(tip);

            return CreatedAtAction(nameof(GetById), new { id = tipDto.Id }, tipDto);
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateTipRequestDto updateTipRequestDto)
        {
            var tip = mapper.Map<Tip>(updateTipRequestDto);

            tip = await tipRepository.UpdateAsync(id, tip);

            if (tip == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<TipDto>(tip));
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var tip = await tipRepository.DeleteAsync(id);

            if (tip == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<TipDto>(tip));
        }
    }
}
