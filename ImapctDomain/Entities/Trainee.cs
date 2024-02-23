namespace ImpactDomain.Entities;

public class Trainee : BaseAuditableEntity
{

   
    public string TraineeName { get; set; }
    public Attendance Attendance { get; set; }
    public int AttendanceId { get; set; }
    public List<string>? AttendanceStatus { get; set; }
}
