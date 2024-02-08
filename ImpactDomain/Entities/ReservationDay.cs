namespace ImpactDomain.Entities;

public class ReservationDay : BaseAuditableEntity
{
    public int ReservationDayId { get; set; }
    public Date Date { get; set; }
    public ExternalReservation ExternalReservation { get; set; }
    public List<string> Services { get; set; }
    public double Expense  { get; set; }
    public double ExpenseCost { get; set;}

}
