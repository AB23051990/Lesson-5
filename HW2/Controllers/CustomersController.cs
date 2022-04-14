using Microsoft.AspNetCore.Mvc;
using HW2.Controllers.Models;

namespace HW2.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

        // �������� ������ ���� ��������
        [HttpGet("get")]
        public IActionResult GetAllCustomers(Customer customer)
        {
            return Ok(customer);
        }

        // �������� ���������� � ������� �� ID
        [HttpGet("get/{id}")]
        public IActionResult GetCustomerById([FromRoute] int id)
        {
            return Ok(id);
        }

        // ����������� ������ �������
        [HttpPost("register")]
        public IActionResult RegisterCustomer([FromBody] Customer customer)
        {
            return Ok(customer);
        }

        // ��������� ������ � �������
        [HttpPut("update/{id}")]
        public IActionResult UpdateCustomer([FromBody] Customer customer)
        {
            return Ok(customer);
        }

        // �������� ������� �� ID
        [HttpDelete("delete/{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            return Ok(id);
        }
    }
}