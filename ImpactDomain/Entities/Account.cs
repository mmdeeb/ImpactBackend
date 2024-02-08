namespace ImpactDomain.Entities;

public class RestaurantAccount : BaseAuditableEntity
{
    public int AccountId { get; set; }
    public Restaurant Restaurant { get; set; }
    public double TotalBalance { get; set; }
    public double Debt { get; set; }
    public List<Paid> Paids { get; set; }
    public List<Mail> Mails { get; set; }
}
