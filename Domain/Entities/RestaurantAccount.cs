namespace Domain.Entities;

public class RestaurantAccount : BaseAuditableEntity, IBaseAccountEntity
{
    public Restaurant? Restaurant { get; set; }
    public int RestaurantId { get; set; }
   
    public List<Mail>? Mails { get; set; }
    public double TotalBalance { get ; set ; }
    public double Debt { get; set; }
    public List<Paid>? Paids { get; set; }
}
