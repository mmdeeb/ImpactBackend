namespace Domain.Entities;

public class LogisticCost : BaseAuditableEntity
{
    public string? Details { get; set; }
    public string? PhotoInvoiceURL { get; set; }
    public User? Person { get; set; }
    public int UserId { get; set; }//need to edit from user to person
 
    public int SupplierId { get; set; }
    public Center? Center { get; set; }
    public int CenterId { get; set; }
    public List<Paid>? Paids { get; set; }
    public double TotalBalance { get; set; }
    public double Debt { get; set; }
   
}
