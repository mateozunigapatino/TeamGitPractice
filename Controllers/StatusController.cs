using Microsoft.AspNetCore.Mvc;

namespace TeamGitPractice.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StatusController : ControllerBase
{
    [HttpGet]
    public IActionResult GetStatus()
    {
        return Ok(new { status = "Running" });
    }


    [HttpGet]
    public IActionResult GetTeamStatus()
    {
        return Ok(new { team = "Trio Dinamico", status = "Listo" });
    }
}
    