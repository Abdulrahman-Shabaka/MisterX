namespace Domain.Entities;

public class Branch : BaseAuditableEntity
{
    public string? Name { get; set; }

    public List<Room>? Rooms { get; set; }
}