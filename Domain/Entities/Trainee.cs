namespace Domain.Entities;

public class Trainee : BaseAuditableEntity
{

   
    public string? TraineeName { get; set; }
    public Attendance? Attendance { get; set; }
    public int AttendanceId { get; set; }
    public string? ListAttendanceStatus { get; set; }
    public Training Training { get; set; }
    public int TrainingId { get; set; }
}
