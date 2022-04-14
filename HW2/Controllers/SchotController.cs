using HW2.Controllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace HW2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {



        [HttpGet("get")]
        public IActionResult GetAllInvoices([FromBody] Schot contractDto)
        {
            return Ok(contractDto);
        }

        [HttpPut("update")]
        public IActionResult UpdateInvoice([FromBody] Schot invoiceDto)
        {

            return Ok(invoiceDto);
        }
    }
}