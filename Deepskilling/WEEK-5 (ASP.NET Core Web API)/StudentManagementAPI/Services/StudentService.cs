using StudentManagementAPI.DTOs;
using StudentManagementAPI.Interfaces;
using StudentManagementAPI.Models;

namespace StudentManagementAPI.Services;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _repository;

    public StudentService(IStudentRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<StudentDto>> GetAllAsync()
    {
        var students = await _repository.GetAllAsync();

        return students.Select(s => new StudentDto
        {
            Id = s.Id,
            Name = s.Name,
            Age = s.Age,
            Department = s.Department,
            Email = s.Email
        });
    }

    public async Task<StudentDto?> GetByIdAsync(int id)
    {
        var student = await _repository.GetByIdAsync(id);

        if (student == null)
            return null;

        return new StudentDto
        {
            Id = student.Id,
            Name = student.Name,
            Age = student.Age,
            Department = student.Department,
            Email = student.Email
        };
    }

    public async Task<StudentDto> CreateAsync(CreateStudentDto dto)
    {
        var student = new Student
        {
            Name = dto.Name,
            Age = dto.Age,
            Department = dto.Department,
            Email = dto.Email
        };

        await _repository.AddAsync(student);

        return new StudentDto
        {
            Id = student.Id,
            Name = student.Name,
            Age = student.Age,
            Department = student.Department,
            Email = student.Email
        };
    }

    public async Task<bool> UpdateAsync(int id, UpdateStudentDto dto)
    {
        var student = await _repository.GetByIdAsync(id);

        if (student == null)
            return false;

        student.Name = dto.Name;
        student.Age = dto.Age;
        student.Department = dto.Department;
        student.Email = dto.Email;

        await _repository.UpdateAsync(student);

        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var student = await _repository.GetByIdAsync(id);

        if (student == null)
            return false;

        await _repository.DeleteAsync(student);

        return true;
    }
}