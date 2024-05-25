using Microsoft.AspNetCore.Mvc;
using MyApi.Models;

[Route("api/[controller]")]
[ApiController]
public class DataController : ControllerBase
{
    [HttpPost]
    public IActionResult Post([FromBody] MyDataModel data)
    {
        if (data == null)
        {
            return BadRequest("Data is null");
        }

        // format and process data

        return Ok(new { message = "Data received successfully", data });
    }
}