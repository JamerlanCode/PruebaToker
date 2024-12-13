using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging; 


[ApiController]
[Route("api/[controller]")]
public class ContactController : ControllerBase {

    private readonly ILogger<ContactController> _logger;

    public ContactController(ILogger<ContactController> logger){
        _logger = logger;
    }

    [HttpPost("sendcontact")]
    public IActionResult CreateContact ([FromBody] Contact contact)
    {
        if (contact == null)
        {
            return BadRequest("Contact Info cant be null.");
        }
        _logger.LogInformation("Contacto llegado desde el POST -> Nombre: {ContactName} -  Telefono: {ContactPhone}", contact.ContactName, contact.ContactPhone);
        return Ok(new { Message = "Registration Succesfully"});
    }
}
