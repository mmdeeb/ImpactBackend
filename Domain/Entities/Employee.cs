﻿namespace Domain.Entities;

public class Employee : User
{
    public Center? Center { get; set; }
    public int CenterId { get; set; }
    public string? EmployeeType { get; set; }
    public double Salary { get; set; }
    public EmployeeAccount? EmployeeAccount { get; set; }
    public int EmployeeAccountId { get; set; }
}
