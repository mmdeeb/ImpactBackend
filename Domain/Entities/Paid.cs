namespace Domain.Entities;

public class Paid : BaseAuditableEntity
{
    //يجب تحديد نوع الحساب يشكل صحيح
    public RestaurantAccount? Account { get; set;}
    public int RestaurantAccountId { get; set; }
    public SupplierAccount? SupplierAccount { get; set;}
    public int SupplierAccountId { get; set;}
    public TrainerAccount? TrainerAccount { get; set; }
    public int TrainerAccountId { get;set; }
    public EmployeeAccount? EmployeeAccount { get; set; }
    public int EmployeeAccountId { get; set; }
    public double PaymentAmount { get; set; }
    public DateTime Date { get; set;}
    public string? Receiver { get; set; }
    public string? Payer { get; set; }
}
