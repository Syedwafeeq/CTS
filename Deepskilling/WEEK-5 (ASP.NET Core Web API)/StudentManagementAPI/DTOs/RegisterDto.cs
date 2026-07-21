using System.ComponentModel.DataAnnotations;

namespace StudentManagementAPI.DTOs;

public class RegisterDto
{
    [Required]
    public string Username { get; set; } = string.Empty;

    [Required]
    public string Password { get; set; } = string.Empty;

    public string Role { get; set; } = "User";
}