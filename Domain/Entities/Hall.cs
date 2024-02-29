namespace Domain.Entities;

public class Hall : BaseAuditableEntity
{
    public string? HallName { get; set;}
    public Center? Center { get; set;}
    public int CenterId { get; set; }
    public List<Reservation>? Reservations { get; set; }
    public string? ListDetials { get; set; }

}
