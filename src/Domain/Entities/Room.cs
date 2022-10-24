namespace Domain.Entities;
public class Room : BaseAuditableEntity
{
    public string? Name { get; set; }
    public string? Code { get; set; }


    public int BranchId { get; set; }
    public Branch? Branch { get; set; }

    public List<Schedule>? Schedules { get; set; }
}
