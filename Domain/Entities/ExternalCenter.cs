
namespace Domain.Entities;

public class ExternalCenter : BaseAuditableEntity
{
    public string? ExternalCenterName { get; set;}
    public string? Location { get; set;}
    public double TotalBalance { get; set; }
    public double Dept { get; set; }
    public List<ExternalReservation>? ExternalReservations { get; set; } 
}
