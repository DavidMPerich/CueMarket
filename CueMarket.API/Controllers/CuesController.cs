using CueMarket.API.Data;
using CueMarket.API.Models.Domain;
using CueMarket.API.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CueMarket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuesController : ControllerBase
    {
        private readonly CueMarketDbContext dbContext;

        public CuesController(CueMarketDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            //Get Domain Models From Database
            var cues = dbContext.Cues.ToList();

            //Map Domain Models to DTOs
            var cuesDto = new List<CueDto>();
            foreach (var cue in cues)
            {
                cuesDto.Add(new CueDto
                {
                    Id = cue.Id,
                    Maker = cue.Maker,
                    ButtId = cue.ButtId,
                    JointType = cue.JointType
                });
            }

            //Return DTOs
            return Ok(cuesDto);
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            var cue = dbContext.Cues.FirstOrDefault(x => x.Id == id);
            
            if (cue == null)
            {
                return NotFound();
            }

            var cueDto = new CueDto
            {
                Id = cue.Id,
                Maker = cue.Maker,
                ButtId = cue.ButtId,
                JointType = cue.JointType
            };

            return Ok(cueDto);
        }

        [HttpPost]
        public IActionResult Create([FromBody] AddCueRequestDto addCueRequestDto)
        {
            var cue = new Cue
            {
                Id = Guid.NewGuid(),
                Maker = addCueRequestDto.Maker,
                ButtId = addCueRequestDto.ButtId,
                JointType = addCueRequestDto.JointType
            };

            dbContext.Cues.Add(cue);
            dbContext.SaveChanges();

            var cueDto = new CueDto
            {
                Id = cue.Id,
                Maker = cue.Maker,
                ButtId = cue.ButtId,
                JointType = cue.JointType
            };

            return CreatedAtAction(nameof(GetById), new { id = cueDto.Id }, cueDto);
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public IActionResult Update([FromRoute] Guid id, [FromBody] UpdateCueRequestDto updateCueRequestDto)
        {
            var cue = dbContext.Cues.FirstOrDefault(x => x.Id == id);
            
            if (cue == null)
            {
                return NotFound();
            }

            cue.Maker = updateCueRequestDto.Maker;
            cue.ButtId = updateCueRequestDto.ButtId;
            cue.JointType = updateCueRequestDto.JointType;

            dbContext.SaveChanges();

            var cueDto = new CueDto
            {
                Id = cue.Id,
                Maker = cue.Maker,
                ButtId = cue.ButtId,
                JointType = cue.JointType
            };

            return Ok(cueDto);
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public IActionResult Delete([FromRoute] Guid id)
        {
            var cue = dbContext.Cues.FirstOrDefault(x => x.Id == id);

            if (cue == null)
            {
                return NotFound();
            }

            dbContext.Cues.Remove(cue);
            dbContext.SaveChanges();

            var cueDto = new CueDto
            {
                Id = cue.Id,
                Maker = cue.Maker,
                ButtId = cue.ButtId,
                JointType = cue.JointType
            };

            return Ok(cueDto);
        }
    }
}
