namespace ImpactDomain.Entities;

public class Attendance : BaseAuditableEntity
{
    public int AttendanceId { get; set; }
    public List<Trainee> Trainee { get; set; }
    public DateTime AttendanceName { get; set;}
}
