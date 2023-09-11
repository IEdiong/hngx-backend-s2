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
    public ActionResult<IEnumerable<User>> GetAllPersons()
    {
        return Ok(_personContext.Users.ToList());
    }

    // GET: /api/userid
    [HttpGet("{userid}", Name = "GetPerson")]
    public ActionResult<User> GetPersonById([FromRoute] int userId)
    {
        var user = _personContext.Users.FirstOrDefault(user => user.Id == userId);
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
        DateTime currentDateTime = DateTime.Now;
        string formattedDateTime = currentDateTime.ToString("yyyy-MM-ddTHH:mm:ssZ");
        User userToAdd = new()
        {
            FirstName = newUser.FirstName,
            LastName = newUser.LastName,
            Email = newUser.Email,
            Birthdate = newUser.Birthdate,
            Address = newUser.Address,
            PhoneNumber = newUser.PhoneNumber,
            CreatedTime = DateTime.UtcNow,
            UpdatedTime = DateTime.UtcNow
        };
        _personContext.Users.Add(userToAdd);
        _personContext.SaveChanges();

        return NoContent();
    }

    // PUT: /api/userid
    [HttpPut("{userid}")]
    public ActionResult UpdatePerson(
        int userId, [FromBody] PersonForCreationDto updateUser)
    {
        var userFromStore = _personContext.Users
            .FirstOrDefault(user => user.Id == userId);

        if (userFromStore == null)
        {
            return NotFound();
        }

        userFromStore.FirstName = updateUser.FirstName;
        userFromStore.LastName = updateUser.LastName;
        userFromStore.Email = updateUser.Email;
        userFromStore.Address = updateUser.Address;
        userFromStore.PhoneNumber = updateUser.PhoneNumber;
        userFromStore.UpdatedTime = DateTime.Now;

        _personContext.SaveChanges();

        return NoContent();
    }

    // DELETE: /api/userid
    [HttpDelete("{userid}")]
    public ActionResult DeletePerson(int userId)
    {
        var userFromStore = _personContext.Users
            .FirstOrDefault(user => user.Id == userId);

        if (userFromStore == null)
        {
            return NotFound();
        }

        _personContext.Users.Remove(userFromStore);
        _personContext.SaveChanges();

        return NoContent();
    }
}

