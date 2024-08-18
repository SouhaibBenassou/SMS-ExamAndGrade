using System.ComponentModel.DataAnnotations;

namespace Domain.EntitiesFromOtherServices.FiliereService;

public abstract class FiliereBaseEntity
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; } = false;
    public string? CreatedBy { get; set; }
    public string? ModifiedBy { get; set; }
    public string? DeletedBy { get; set; }
}