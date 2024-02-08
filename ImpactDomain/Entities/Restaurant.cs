namespace ImpactDomain.Entities;

public class Restaurant : BaseAuditableEntity
{
    public int RestaurantId { get; set; }
    public string RestaurantName { get; set; }
    public string ResEmployee { get; set; }
}
