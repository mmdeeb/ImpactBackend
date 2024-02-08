namespace ImpactDomain.Entities;

public class Ads : BaseAuditableEntity
{
    public int AdsId { get; set; }
    public List<string> AdsMedia { get; set;}
    public string AdsTitle { get; set;}
    public string AdsDescription { get; set;}
}
