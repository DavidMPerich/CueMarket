using AutoMapper;
using CueMarket.API.Models.Domain;
using CueMarket.API.Models.DTO;
using CueMarket.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CueMarket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ICueRepository cueRepository;
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public UsersController(ICueRepository cueRepository, IUserRepository userRepository, IMapper mapper)
        {
            this.cueRepository = cueRepository;
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // Get Domain Models From Database
            var users = await userRepository.GetAllAsync();

            // Return DTOs
            return Ok(mapper.Map<List<UserDto>>(users));
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var user = await userRepository.GetByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<UserDto>(user));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddUserRequestDto addUserRequestDto)
        {
            var user = mapper.Map<User>(addUserRequestDto);

            user = await userRepository.CreateAsync(user);

            var userDto = mapper.Map<UserDto>(user);

            return CreatedAtAction(nameof(GetById), new { id = userDto.Id }, userDto);
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateUserRequestDto updateUserRequestDto)
        {
            var user = mapper.Map<User>(updateUserRequestDto);

            user = await userRepository.UpdateAsync(id, user);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<UserDto>(user));
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var user = await userRepository.DeleteAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<UserDto>(user));
        }
    }
}
