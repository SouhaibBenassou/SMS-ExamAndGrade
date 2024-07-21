using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.TestDto
{
    public class TestDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? TestStatement { get; set; }
        public string? TestCorrection { get; set; }
        public double? Note { get; set; }
        public Guid UnitOfFormationId { get; set; }
    }
}
