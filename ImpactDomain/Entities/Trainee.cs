using ImpactDomain.Entities;

namespace ImpactDomain.Entitiesl;

public class Trainee : BaseAuditableEntity
{
    public int TraineeID { get; set; }
    public string TraineeName { get; set; }
    public Attendance Attendance { get; set; }
    public List<bool> AttendanceStatus { get; set; }
}
