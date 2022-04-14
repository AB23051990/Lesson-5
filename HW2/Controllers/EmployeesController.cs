using HW2.Controllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace HW2.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {

        // �������� ������ ���� ����������
        [HttpGet("get")]
        public IActionResult GetAllEmployees(Employee employeeInfo)
        {
            return Ok(employeeInfo);
        }

        // �������� ���������� � ��������� �� ID
        [HttpGet("get/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            return Ok(id);
        }

        // ����������� ������ ���������
        [HttpPost("register")]
        public IActionResult Post([FromBody] Employee employeeInfo)
        {
            return Ok(employeeInfo);
        }

        // ��������� ������ � ���������
        [HttpPut("update/{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Employee employeeInfo)
        {
            return Ok(employeeInfo);
        }

        // �������� ��������� �� ID
        [HttpDelete("delete/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            return Ok(id);
        }
    }
}