namespace Domain.Entities
{
    public class Student : BaseAuditableEntity
    {


        public string Fname { get; set; }
        public string Lname { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public Level Level { get; set; }
        public Room Room { get; set; }
    }

    public enum Gender
    {
        Male = 0,
        Female = 1
    }

    public enum Level
    {
        Level1 = 1,
        Level2 = 2,
        Level3 = 3
    }
}
