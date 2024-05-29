using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OffenseController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] OffenseRecord record)
        {
            if (record == null)
            {
                return BadRequest("Invalid data.");
            }

            // Process data (e.g., save to a database)
            
//            Console.WriteLine($"Received data: {record.Aktenzeichen}, {record.Anrede}, {record.Vorname}");

            return Ok(new { message = "Data received successfully", data = record });
        }
    }
}
