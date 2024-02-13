namespace ImpactDomain.Entities;

public class AdditionalCost : BaseAuditableEntity
{
    public double Cost { get; set; }
    public string Detailes { get; set; }
    public DateTime Date { get; set; }
    public  string? PhotoInvoiceURL { get; set; }
    public Traning? Traning { get; set; }
    public int TraningId { get; set; }


}
