using hngXStageTwo.DbContexts;
using hngXStageTwo.Entities;
using hngXStageTwo.Models;
using Microsoft.AspNetCore.Mvc;

namespace hngXStageTwo.Controllers;

[ApiController]
[Route("api/")]
public class PersonController : ControllerBase
{
    private readonly PersonContext _personContext;

    public PersonController(PersonContext personContext)
    {
        _personContext = personContext;
    }

    // GET: /api/
    [HttpGet]
    public ActionResult<IEnumerable<Person>> GetAllPersons(string? name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return Ok(_personContext.People.ToList());
        }

        var users = _personContext.People
            .Where(p => p.Name.ToLower() == name.ToLower())
            .ToList();

        return Ok(users);
    }

    // GET: /api/userid
    [HttpGet("{userId}", Name = "GetPerson")]
    public ActionResult<Person> GetPersonById([FromRoute] int userId)
    {
        var user = _personContext.People.FirstOrDefault(user => user.Id == userId);
        if (user == null)
        {
            return NotFound();
        }

        return Ok(user);
    }

    // POST: /api/
    [HttpPost]
    public ActionResult CreatePerson(PersonForCreationDto newUser)
    {
        Person userToAdd = new()
        {
            Name = newUser.Name,
            Email = newUser.Email,
        };
        _personContext.People.Add(userToAdd);
        _personContext.SaveChanges();

        return CreatedAtRoute("GetPerson", new
        {
            userId = userToAdd.Id
        }, userToAdd);
    }

    // PUT: /api/userid
    [HttpPut("{userId}")]
    public ActionResult UpdatePerson(
        int userId, [FromBody] PersonForCreationDto updateUser)
    {
        var userFromStore = _personContext.People
            .FirstOrDefault(user => user.Id == userId);

        if (userFromStore == null)
        {
            return NotFound();
        }

        userFromStore.Name = updateUser.Name;
        userFromStore.Email = updateUser.Email;

        _personContext.SaveChanges();

        return NoContent();
    }

    // DELETE: /api/userid
    [HttpDelete("{userId}")]
    public ActionResult DeletePerson(int userId)
    {
        var userFromStore = _personContext.People
            .FirstOrDefault(user => user.Id == userId);

        if (userFromStore == null)
        {
            return NotFound();
        }

        _personContext.People.Remove(userFromStore);
        _personContext.SaveChanges();

        return NoContent();
    }
}

