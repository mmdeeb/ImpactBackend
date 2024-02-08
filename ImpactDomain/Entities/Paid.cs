namespace ImpactDomain.Entities;

public class Paid : BaseAuditableEntity
{
    public int PaidId { get; set; }
    //يجب تحديد نوع الحساب يشكل صحيح
    public RestaurantAccount Account { get; set;}
    public double PaymentAmount { get; set; }
    public DateTime Date { get; set;}
    public string Receiver { get; set; }
    public string Payer { get; set; }
}
