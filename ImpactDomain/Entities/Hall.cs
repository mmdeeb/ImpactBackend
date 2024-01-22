namespace ImpactDomain.Entities;

public class Hall : BaseAuditableEntity
{
    public int HallId { get; set; }
    public string HallName { get; set;}
    public Center Center { get; set;}


}
