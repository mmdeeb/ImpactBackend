﻿namespace Domain.Entities;

public class Restaurant : BaseAuditableEntity
{
    public string? RestaurantName { get; set; }
    public string? ResEmployee { get; set; }
    public RestaurantAccount? RestaurantAccount { get; set; }
    public int RestaurantAccountId { get; set; }
}
