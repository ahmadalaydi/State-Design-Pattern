using Microsoft.AspNetCore.Mvc;
using State_Design_Pattern.Domain.Entity.Users.Exceptions;
using State_Design_Pattern.Domain.Interfaces;

namespace State_Design_Pattern.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserRepository _userRepository;

    public UsersController(IUserRepository userRepository)
    => _userRepository = userRepository;

    [HttpGet("all")]
    public IActionResult GetAll()
    => Ok(_userRepository.GetAll());

    [HttpPost("{id}/activate")]
    public IActionResult Activate(int id)
    {
        var user = _userRepository.GetById(id);
        if (user is null)
            return NotFound();

        try
        {
            user.Activate();
            return Ok();
        }
        catch (AlreadyActiveException)
        {
            return BadRequest("Uesr Already Active");
        }
    }

    [HttpPost("{id}/deactivate")]
    public IActionResult DeActivate(int id)
    {
        var user = _userRepository.GetById(id);
        if (user is null)
            return NotFound();

        try
        {
            user.DeActivate();
            return Ok();
        }
        catch (AlreadyInActiveException)
        {
            return BadRequest("Uesr Already InActive");
        }
    }
}
