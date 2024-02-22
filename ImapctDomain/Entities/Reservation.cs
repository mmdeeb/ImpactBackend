namespace ImpactDomain.Entities;

public class Reservation : BaseAuditableEntity
{
    public Hall Hall { get; set;}
    public int HallId { get; set; }
    public Client Client { get; set; }
    public int ClientId { get; set; }
    public string Status { get; set; }
    public double Cost { get; set; }
    public List<Training> Training { get; set; }


}
