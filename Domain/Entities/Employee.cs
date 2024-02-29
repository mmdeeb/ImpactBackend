namespace Domain.Entities;

public class Employee : BaseAuditableEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Phone { get; set; }
    public Center? Center { get; set; }
    public int CenterId { get; set; }
    public string? EmployeeTupe { get; set; }
    public double Salary { get; set; }
}
