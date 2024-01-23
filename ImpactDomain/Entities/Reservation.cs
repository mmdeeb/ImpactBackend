namespace ImpactDomain.Entities;

public class Reservation : BaseAuditableEntity
{
    public int ReservationId { get; set; }
    public Hall Hall { get; set;}
    public Client Client { get; set; }
    public string Status { get; set; }
    public double Cost { get; set; }
    public List<Traning> Training { get; set; }


}
