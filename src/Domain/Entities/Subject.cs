namespace Domain.Entities;

public class Subject : BaseAuditableEntity
{
    public string? Name { get; set; }
    public Level Level { get; set; }

    public List<Student>? Students { get; set; }
    public List<Teacher>? Teachers { get; set; }
}