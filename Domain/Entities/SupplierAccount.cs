namespace Domain.Entities;

public class SupplierAccount : BaseAuditableEntity
{

 
    public string? SupplierName { get; set; }
    public string? Address { get; set; }
    public double TotalBalance { get ; set ; }
    public double Debt { get; set; }
  //  public List<Receipt>? Receipts { get; set; }
}
