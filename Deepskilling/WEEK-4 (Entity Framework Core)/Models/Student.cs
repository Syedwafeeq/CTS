using System.ComponentModel.DataAnnotations;

namespace WEEK_4_Entity_Framework_Core.Models;

public class Student
{
    [Key]
    public int StudentId { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public int Age { get; set; }
}