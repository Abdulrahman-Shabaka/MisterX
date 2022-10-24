namespace Domain.Entities;
public class Student : BaseAuditableEntity
{
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
    public string? Email { get; set; }
    public Gender Gender { get; set; }
    public string? Address { get; set; }
    public Level Level { get; set; }
    public List<Subject>? Subjects { get; set; }
    public List<Schedule>? Schedules { get; set; }
}

