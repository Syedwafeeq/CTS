using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.DTOs;
using StudentManagementAPI.Interfaces;

namespace StudentManagementAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class StudentController : ControllerBase
{
    private readonly IStudentService _service;
    private readonly ILogger<StudentController> _logger;

    public StudentController(
        IStudentService service,
        ILogger<StudentController> logger)
    {
        _service = service;
        _logger = logger;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<StudentDto>>> GetStudents()
    {
        _logger.LogInformation("Fetching all students.");

        return Ok(await _service.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<StudentDto>> GetStudent(int id)
    {
        _logger.LogInformation("Fetching student with Id: {Id}", id);

        var student = await _service.GetByIdAsync(id);

        if (student == null)
            return NotFound();

        return Ok(student);
    }

    [HttpPost]
    public async Task<ActionResult<StudentDto>> CreateStudent(CreateStudentDto dto)
    {
        _logger.LogInformation("Creating a new student.");

        var student = await _service.CreateAsync(dto);

        return CreatedAtAction(
            nameof(GetStudent),
            new { id = student.Id },
            student);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateStudent(int id, UpdateStudentDto dto)
    {
        _logger.LogInformation("Updating student with Id: {Id}", id);

        var updated = await _service.UpdateAsync(id, dto);

        if (!updated)
            return NotFound();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteStudent(int id)
    {
        _logger.LogInformation("Deleting student with Id: {Id}", id);

        var deleted = await _service.DeleteAsync(id);

        if (!deleted)
            return NotFound();

        return NoContent();
    }
}