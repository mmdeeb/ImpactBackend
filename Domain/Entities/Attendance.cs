namespace Domain.Entities;

public class Attendance : BaseAuditableEntity
{
    public List<Trainee>? Trainee { get; set; }
    public DateTime AttendanceName { get; set;}
}
