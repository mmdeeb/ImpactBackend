namespace ImpactDomain.Entities;

public class TrainingInvoice : BaseAuditableEntity
{
    public double ReservationsCost { get; set; }
    public List<AdditionalCost>? AdditionalCosts { get; set; }
    public List<LogisticCost>? LogisticCosts { get; set; }
    public Training Traning { get; set; }
    public int TraningId { get; set; }
    public string? PhotoInvoiceURL { get; set; }

}
