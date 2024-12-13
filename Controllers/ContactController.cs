using Microsoft.AspNetCore.Mvc;
using System.Text.Json;


[ApiController]
[Route("api/[controller]")]
public class ContactController : ControllerBase {
    [HttpPost("sendcontact")]
    public IActionResult CreateContact ([FromBody] Contact contact)
    {
        if (contact == null)
        {
            return BadRequest("los datos estan mal");
        }

        return Ok(new { Message = "Registration Succesfully"});
    }
}
