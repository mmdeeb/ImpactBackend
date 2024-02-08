namespace ImpactDomain.Entities;

public class ExternalReservation : BaseAuditableEntity
{
    public int ExternalReservationId { get; set; }
    public ExternalCenter ExternalCenter { get; set; }
    public List<ReservationDay> ReservationDays { get; set; }
}
