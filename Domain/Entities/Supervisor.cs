﻿using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public class Supervisor : AuditableEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Title { get; set; }
        
        public ICollection<ExamSession>? ExamSessions { get; set; }
    }
}

