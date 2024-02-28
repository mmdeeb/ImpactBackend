namespace ImpactDomain.Entities;

public class ReservationDay : BaseAuditableEntity
{
    public DateTime Date { get; set; }
    public ExternalReservation ExternalReservation { get; set; }
    public int ExternalReservationId { get; set; }
    public string Services { get; set; }
    public double Expense  { get; set; }
    public double ExpenseCost { get; set;}

}
