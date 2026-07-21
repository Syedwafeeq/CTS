using System.ComponentModel.DataAnnotations;

namespace StudentManagementAPI.DTOs;

public class CreateStudentDto
{
    [Required]
    public string Name { get; set; } = string.Empty;

    [Range(18,100)]
    public int Age { get; set; }

    [Required]
    public string Department { get; set; } = string.Empty;

    [EmailAddress]
    public string Email { get; set; } = string.Empty;
}