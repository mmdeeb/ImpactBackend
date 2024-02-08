
namespace ImpactDomain.Entities;

public class ExternalCenter : BaseAuditableEntity
{
    public int ExternalCenterID { get; set; }
    public string ExternalCenterName { get; set;}
    public string Location { get; set;}
    public double TotalBalance { get; set; }
    public double Dept { get; set; }
    public List<Paid> Paids { get; set; }
    public List<ExternalReservation> ExternalReservations { get; set; } 

}
