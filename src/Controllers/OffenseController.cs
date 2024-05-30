using Microsoft.AspNetCore.Mvc;
using backend.Models;

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

            // format
            // save to db
            
            return Ok(new { message = "Ordungswidrigkeit wurde erfolgreich eingetragen.", data = record });
        }
    }
}
