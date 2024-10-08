﻿using Domain.EntitiesFromOtherServices.FiliereService;
using Domain.Enums;

namespace Domain.Entities
{
    public class VariantsExams : AuditableEntity
    {
        public Guid? ExamId { get; set; }
        public Exam? Exam { get; set; }
        public string? Description { get; set; }
        public string? VariantName { get; set; }
        public string? ExamStatement { get; set; }
        public string? ExamCorrection { get; set; }
        public Guid? UnitOfFormationId { get; set; }
        public UnitOfFormation? UnitOfFormation { get; set; }
        public VariantType? VariantType { get; set; }
        public int? NoteMax { get; set; }
        public bool? IsValid { get; set; }
        public Guid? TrainerId { get; set; }

    }
}
