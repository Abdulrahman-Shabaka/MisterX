namespace Domain.Entities;

public class Parent : BaseAuditableEntity
{
    public string? Name { get; set; }
    public List<Student>? Students { get; init; }
}

