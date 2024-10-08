﻿
using Domain.Entities;

namespace Domain;

public class AllResults : AuditableEntity
{
    public Guid ExamResultId { get; set; }
    public ExamResult? ExamResult { get; set; }
    public Guid TestResultsId { get; set; }
    public TestResult? TestResults { get; set; }
}
