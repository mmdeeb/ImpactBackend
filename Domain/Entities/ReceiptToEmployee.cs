namespace Domain.Entities;

public class ReceiptToEmployee : Receipt
{

    public EmployeeAccount? EmployeeAccount { get; set; }
    public int EmployeeAccountId { get; set; }
}
