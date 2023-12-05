using FisioFinancials.Domain.Model.DTOs;
using FisioFinancials.Domain.Model.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FisioFinancials.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private UserManager<User> _userManager;

    public UsersController
    (
       UserManager<User> userManager
    )
    {
        _userManager = userManager;
    }

    [HttpPost]
    public async Task<IActionResult> RegisterUser([FromBody] CreateUserDTO userDTO)
    {
        User user = new()
        {
            Email = userDTO.Email,
            FirstName = userDTO.FirstName,
            LastName = userDTO.LastName
        };

        IdentityResult result = await _userManager.CreateAsync(user, userDTO.Password);

        if (result.Succeeded)
        {
            return Ok("User registered");
        }

        throw new ApplicationException("Error on register user");
    }
}
