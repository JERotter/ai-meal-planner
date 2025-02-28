using Microsoft.AspNetCore.Mvc;

namespace PeriPeri.API.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{

    public UserController()
    {
    }

    [HttpGet(Name = "GetUsers")]
    public IEnumerable<User> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new User
        {
            FirstName = "Jane",
            LastName = "Doe",
            Id = Guid.NewGuid()
        })
        .ToArray();
    }
}
