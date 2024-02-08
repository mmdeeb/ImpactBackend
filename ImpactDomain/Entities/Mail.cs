namespace ImpactDomain.Entities;

public class Mail : BaseAuditableEntity
{
    //هنا يوجد اشكالية بحيث هل نضع لستة وجبات كدفعة واحدة ونربطها بمطعم
    public int MailId { get; set; }
    public string MailName { get; set; }
    public User Organization { get; set; }
    public string Number { get; set;}
    public double MailPrice { get; set; }
    public double MailPriceForORG { get; set;}
    public double TotalPrice { get; set; }
    public double TotalPriceForORG { get; set; }
    
}

