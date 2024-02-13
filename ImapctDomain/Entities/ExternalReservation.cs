namespace ImpactDomain.Entities;

public class ExternalReservation : BaseAuditableEntity
{
    public ExternalCenter ExternalCenter { get; set; }
    public int ExternalCenterID { get; set; }
    public List<ReservationDay>? ReservationDays { get; set; }
}
