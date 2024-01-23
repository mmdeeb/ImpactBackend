namespace ImpactDomain.Entities;

public class LogisticCost : BaseAuditableEntity
{
    public int LogisticCostId { get; set; }
    public string Details { get; set; }
    public string? PhotoInvoiceURL { get; set; }
    public User Person { get; set; }
    public Center Center { get; set; }
}
