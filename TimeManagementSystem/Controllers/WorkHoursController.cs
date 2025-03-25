using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TimeManaementSystem.Core.Entities;
using TimeManaementSystem.Core.Services;
using TimeManagementSystem.Core.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TimeManagementSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkHoursController : ControllerBase
    {
        private readonly IWorkHoursService _workHoursService;
        private readonly IMapper _mapper;
        public WorkHoursController(IWorkHoursService workHours,IMapper mapper)
        {
            _workHoursService = workHours;
            _mapper = mapper; 
        }

        // GET: api/<WorkHoursController>
        [HttpGet]
        [Authorize]
        public async Task<ActionResult> Get()
        {
             var workHours =await _workHoursService.GetListAsync();
            var workHoursDto = _mapper.Map<IEnumerable<WorkHoursDto>>(workHours);
            return Ok(workHoursDto);
        }

        // GET api/<WorkHoursController>/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult> Get(int id)
        {
            var workHours =await _workHoursService.GetByIdAsync(id);
            var WorkHoursDto = _mapper.Map<IEnumerable<WorkHoursDto>>(workHours);
            return Ok(WorkHoursDto);
        }

        // POST api/<WorkHoursController>
        [HttpPost]
        [Authorize(Roles = "Manager")]
        public async Task<ActionResult> Post([FromBody] WorkHoursDto workHours)
        {
            var newWorkHours =await _workHoursService.AddAsync(_mapper.Map<WorkHours>(workHours));
            return Ok(newWorkHours);
        }

        // PUT api/<WorkHoursController>/5
        [HttpPut("{id}")]
        [Authorize(Roles = "Manager")]
        public async Task<ActionResult> Put(int id, [FromBody] WorkHoursDto workHours)
        {
            var updateWorkHours =await _workHoursService.UpdateAsync(_mapper.Map<WorkHours>(workHours));
            return Ok(updateWorkHours);
        }

        // DELETE api/<WorkHoursController>/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Manager")]
        public async Task<ActionResult> Delete(int id)
        {
           await _workHoursService.DeleteAsync(id);
            return Ok();
        }
    }
}
