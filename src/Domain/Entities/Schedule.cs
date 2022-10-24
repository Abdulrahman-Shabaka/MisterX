namespace Domain.Entities;

public class Schedule : BaseAuditableEntity
{

    public DateTime? StartedAt { get; set; }
    public DateTime? EndedAt { get; set; }


    public int BranchId { get; set; }
    public Branch? Branch { get; set; }

    public int RoomId { get; set; }
    public Room? Room { get; set; }

    public int TeacherId { get; set; }
    public Teacher? Teacher { get; set; }

    public int SubjectId { get; set; }
    public Subject? Subject { get; set; }

    public List<Student>? Students { get; set; }


}
