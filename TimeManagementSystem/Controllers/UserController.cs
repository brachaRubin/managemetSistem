using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NLog;
using TimeManaementSystem.Core.Entities;
using TimeManaementSystem.Core.Services;
using TimeManagementSystem.Api.Models;
using TimeManagementSystem.Core.DTOs;

namespace TimeManagementSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Manager")]
    public class UserController : ControllerBase
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UserController(IUserService userService,IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }
          // GET: api/<UserController>
          [HttpGet]
        [Authorize]
        public async Task<ActionResult> Get()
        {
           var users =await _userService.GetListAsync();
            var listUsers = _mapper.Map<IEnumerable<UserDto>>(users);
            return Ok(listUsers);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            Logger.Info("bkbkbkbkbkbk");
            var user =await _userService.GetByIdAsync(id);
            var userDto = _mapper.Map<UserDto>(user);
            return Ok(userDto);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] UserPostModel user)
        {
            var newUser = new User { Email = user.Email,Name = user.Name,Password = user.Password,Role=user.Role };
           await _userService.AddAsync(newUser);
            return Ok(newUser);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UserPostModel user)
        {

            var updateUser = new User { Email = user.Email, Name = user.Name, Password = user.Password, Role = user.Role };
              await  _userService.UpdateAsync(updateUser);
            return Ok(updateUser);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
           await _userService.DeleteAsync(id);
            return Ok();
        }
    }
}
