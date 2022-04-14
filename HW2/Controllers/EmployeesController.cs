using HW2.Controllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace HW2.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {

        // получить список всех работников
        [HttpGet("get")]
        public IActionResult GetAllEmployees(Employee employeeInfo)
        {
            return Ok(employeeInfo);
        }

        // получить информацию о работнике по ID
        [HttpGet("get/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            return Ok(id);
        }

        // регистрация нового работника
        [HttpPost("register")]
        public IActionResult Post([FromBody] Employee employeeInfo)
        {
            return Ok(employeeInfo);
        }

        // изменение данных о работнике
        [HttpPut("update/{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Employee employeeInfo)
        {
            return Ok(employeeInfo);
        }

        // удаление работника по ID
        [HttpDelete("delete/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            return Ok(id);
        }
    }
}