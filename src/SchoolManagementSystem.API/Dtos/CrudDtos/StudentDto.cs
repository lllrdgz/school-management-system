
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SchoolManagementSystem.Domain.Entities;

namespace SchoolManagementSystem.API.Dtos;


public class StudentDto : SchoolMemberDto
{

    [Required]
    public string IDCardNo { get; set; }

    [Required]
    public string TuitorName { get; set; }
    
    [Required]
    public int TuitorPhoneNumber { get; set; }

    [Required]
    public int Founds { get; set; }

    [Required]
    public string ScholarityLevel { get; set; }
}
