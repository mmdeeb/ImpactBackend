namespace ImpactDomain.Entities;

public class ExternalReservation : BaseAuditableEntity
{
    public ExternalCenter ExternalCenter { get; set; }
    public int ExternalCenterId { get; set; }
    public List<ReservationDay>? ReservationDays { get; set; }
}
