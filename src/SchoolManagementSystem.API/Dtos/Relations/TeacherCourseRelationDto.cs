
using System.ComponentModel.DataAnnotations;
using SchoolManagementSystem.Domain.Entities;


namespace SchoolManagementSystem.API.Dtos;

public class TeacherCourseRelationDto
{
    [Required]
    public string TeacherId { get; set; }
    // [Required]
    public string TeacherName { get; set; }
    [Required]
    public string CourseId { get; set; }
    // [Required]
    public string CourseName { get; set; }
    [Required]
    public int CorrespondingPorcentage { get; set; }
}
