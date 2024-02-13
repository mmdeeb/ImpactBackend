﻿namespace ImpactDomain.Entities;

public class User : BaseAuditableEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string UserType { get; set; }
}
