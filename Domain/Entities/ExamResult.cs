﻿using Domain.Entities;

namespace Domain;

public class ExamResult : AuditableEntity
{

    public Guid? ExamId { get; set; }
    public Exam? Exam { get; set; }
    public Guid? StagiaireId { get; set; }
    public Stagiaire? Stagiaire { get; set; }
    public double? Note { get; set; }
    public bool? IsValid { get; set; }
    public DateOnly? DateValidation { get; set; }
}