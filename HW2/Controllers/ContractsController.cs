using HW2.Controllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace HW2.Controllers
{

    [Route("api/contracts")]
    [ApiController]
    public class ContractsController : ControllerBase
    {

        [HttpGet("get")]
        public IActionResult GetAllContracts(Contract contract)
        {
            return Ok(contract);
        }

        [HttpGet("get/{id}")]
        public IActionResult GetContractById([FromRoute] int id)
        {
            return Ok(id);
        }

        [HttpPost("register")]
        public IActionResult RegisterContract([FromBody] Contract contract)
        {
            return Ok(contract);
        }

        [HttpPut("update/{id}")]
        public IActionResult UpdateContract([FromBody] Contract contract)
        {

            return Ok(contract);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteContract([FromRoute] int id)
        {
            return Ok(id);
        }
    }
}