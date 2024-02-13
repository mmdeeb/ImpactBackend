namespace ImpactDomain.Entities;

public class AboutUs : BaseAuditableEntity
{
    public List<string>? ContactInfo { get; set; }
    public string? AdditionalInfo { get; set; }
    public List<string>? Links { get; set; }

}
