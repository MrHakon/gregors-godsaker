using Microsoft.AspNetCore.Mvc;

namespace GregorsGodsakApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SnackController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetSnacks()
    {
        return Ok("Here are some snacks");
    }
}