using Microsoft.AspNetCore.Mvc;
namespace TeamGitPractice.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MembersController : ControllerBase
{
    [HttpGet]
    public IActionResult GetMembers()
    {
        var members = new[]
        {
          "Mateo Zúñiga Patiño",
          "Carolina Pineda Ramírez",

 };
        return Ok(members);
    }

}