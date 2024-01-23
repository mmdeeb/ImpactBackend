namespace ImpactDomain.Entities;

public class Center : BaseAuditableEntity
{
    public int CenterId { get; set; }
    public string? CenterName { get; set; }
    public string? CenterLocation { get; set;}
    public string? PhoneNumber { get; set;}
    public User? Manager { get; set;}
    public List<Hall>?  Halls { get; set; }
    public string? Media { get; set; }



}

