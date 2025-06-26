using CueMarket.API.Data;
using CueMarket.API.Models.Domain;
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
            var cues = dbContext.Cues.ToList();

            return Ok(cues);
        }
    }
}
