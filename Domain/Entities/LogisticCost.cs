namespace Domain.Entities;

public class LogisticCost : BaseAuditableEntity
{
    public string? Details { get; set; }
    public string? PhotoInvoiceURL { get; set; }
    public User? Person { get; set; }
    public int UserId { get; set; }//need to edit from user to person
    public Center? Center { get; set; }
    public int CenterId { get; set; }

}
