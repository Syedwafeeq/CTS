using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.DTOs;
using StudentManagementAPI.Interfaces;

namespace StudentManagementAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly ITokenService _tokenService;

    public AuthController(ITokenService tokenService)
    {
        _tokenService = tokenService;
    }

    [HttpPost("login")]
    public IActionResult Login(LoginDto dto)
    {
        // Temporary login for learning
        if (dto.Username == "admin" && dto.Password == "admin123")
        {
            var token = _tokenService.CreateToken("admin", "Admin");

            return Ok(new
            {
                Token = token
            });
        }

        return Unauthorized("Invalid username or password.");
    }
}