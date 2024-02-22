namespace ImpactDomain.Entities;

public class Training : BaseAuditableEntity
{
    public string TrainingName { get; set; }
    public Reservation Reservation { get; set; }
    public int NumberOfStudents { get; set; }
    public string TrainingDetails { get; set;}
    public Client Clint { get; set; }
    public int ClientId { get; set; }
    public List<string>? AdditionalCosts { get; set;}
    public List<Attendance>? Attendances { get; set; }
    public TrainingInvoice TrainingInvoice { get; set; }
}
