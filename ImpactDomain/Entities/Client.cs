namespace ImpactDomain.Entities;
public class Client : BaseAuditableEntity
{
    public int ClientId { get; set; }
    public string ClinetName { get; set; }
    public string PhoneNumber { get; set;}
    public double Amount { get; set;}
    public Reservation Email { get; set;}
}


