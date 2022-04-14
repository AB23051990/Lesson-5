using Microsoft.AspNetCore.Mvc;
using HW2.Controllers.Models;

namespace HW2.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

        // получить список всех клиентов
        [HttpGet("get")]
        public IActionResult GetAllCustomers(Customer customer)
        {
            return Ok(customer);
        }

        // получить информацию о клиенте по ID
        [HttpGet("get/{id}")]
        public IActionResult GetCustomerById([FromRoute] int id)
        {
            return Ok(id);
        }

        // регистрация нового клиента
        [HttpPost("register")]
        public IActionResult RegisterCustomer([FromBody] Customer customer)
        {
            return Ok(customer);
        }

        // изменение данных о клиенте
        [HttpPut("update/{id}")]
        public IActionResult UpdateCustomer([FromBody] Customer customer)
        {
            return Ok(customer);
        }

        // удаление клиента по ID
        [HttpDelete("delete/{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            return Ok(id);
        }
    }
}