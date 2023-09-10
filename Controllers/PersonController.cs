using Microsoft.AspNetCore.Mvc;

namespace hngXStageTwo.Controllers;

[ApiController]
[Route("api/")]
public class PersonController : ControllerBase
{
    // GET: /api/
    [HttpGet]
    public IActionResult GetAllPersons()
    {
        return Ok();
    }

    // GET: /api/user_id
    [HttpGet("{user_id}")]
    public IActionResult GetPersonById(string user_id)
    {
        return Ok();
    }

    // POST: /api/
    [HttpPost]
    public IActionResult CreatePerson()
    {
        return Ok();
    }

    // PUT: /api/user_id
    [HttpPut]
    public IActionResult UpdatePerson()
    {
        return Ok();
    }

    // DELETE: /api/user_id
    [HttpDelete]
    public IActionResult DeletePerson()
    {
        return NoContent();
    }
}

