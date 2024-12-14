using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


[ApiController]
[Route("api/[controller]")]
public class ContactController : ControllerBase
{

    private readonly ILogger<ContactController> _logger;
    private readonly ApplicationDbContext _context;

    public ContactController(ILogger<ContactController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpPost("sendcontact")]
    public async Task<IActionResult> CreateContact([FromBody] Contact contact)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _context.Contacts.Add(contact);
        await _context.SaveChangesAsync();
        _logger.LogInformation("Contacto llegado desde el POST -> Nombre: {ContactName} -  Telefono: {ContactPhone}", contact.ContactName, contact.ContactPhone);
        //return CreatedAtAction(nameof(CreateContact), new { id = contact.Id }, contact);
        return Ok(new { Message = "Registration Succesfully" });
    }
}
