using Microsoft.AspNetCore.Mvc;
using HW3.Controllers.Models;
using HW3.Services;

namespace HW3.Controllers
{
    [Route("api/contracts")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IService<Persons> _service;

        public PersonsController(IService<Persons> service)
        {
            _service = service;
        }

        [HttpGet("persons/{id}")]
        public async Task<IActionResult> GetPersonsById([FromRoute] int id)
        {
            return Ok(await _service.Get(id));
        }

        [HttpGet("persons/{Name}")]
        public async Task<IActionResult> GetPersonsByName([FromRoute] int id)
        {
            return Ok(await _service.Get(id));
        }

        [HttpGet("persons/?skip={5}&take={10}")]
        public async Task<IActionResult> GetAllPersons()
        {
            return Ok(await _service.GetAll());
        }

        [HttpPost("register/persons")]
        public async Task<IActionResult> RegisterPersons([FromBody] Persons contract)
        {
            await _service.Create(contract);
            return Ok();
        }

        [HttpPut("update/persons/{id}")]
        public async Task<IActionResult> UpdatePersons([FromBody] Persons contract)
        {
            await _service.Update(contract);
            return Ok();
        }

        [HttpDelete("delete/persons/{id}")]
        public async Task<IActionResult> DeletePersons([FromRoute] int id)
        {
            await _service.Delete(id);
            return Ok();
        }
    }
}