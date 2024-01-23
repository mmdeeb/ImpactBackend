namespace ImpactDomain.Entities;

public class TrainingInvoice : BaseAuditableEntity
{
    public int TrainingInvoiceId { get; set; }
    public double ReservationsCost { get; set; }
    public List<AdditionalCost> AdditionalCosts { get; set; }
    public List<LogisticCost> LogisticCosts { get; set; }
    public Traning Traning { get; set; }


}
