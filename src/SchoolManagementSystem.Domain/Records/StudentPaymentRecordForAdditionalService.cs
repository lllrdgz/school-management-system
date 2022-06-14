﻿
using System.ComponentModel.DataAnnotations;
using SchoolManagementSystem.Domain.Entities;

namespace SchoolManagementSystem.Domain.Records;

public class StudentPaymentRecordForAdditionalService : Record
{
    [Required]
    public Student Student { get; set; }
    
    [Required]
    public AdditionalService Service { get; set; }
}
