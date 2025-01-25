using Microsoft.AspNetCore.Mvc;

namespace GregorsGodsakApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SnackController : ControllerBase
{
    [HttpGet]
    public IActionResult GetSnacks()
    {
        var results = new List<string>
        {
            "Sjokolade",
            "Banan",
            "Punsjrull"
        };
        
        return Ok(results);
    }
}