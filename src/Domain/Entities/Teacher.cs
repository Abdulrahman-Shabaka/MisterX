namespace Domain.Entities;

public class Teacher : BaseAuditableEntity
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }

    public int SubjectId { get; set; }
    public Subject? Subject { get; set; }
    public List<Schedule>? Schedules { get; set; }
}
