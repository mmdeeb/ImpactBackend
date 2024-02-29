﻿namespace Domain.Entities;

public class Trainer : BaseAuditableEntity
{
    public string?TrainerName { get; set; }
    public string? ListSkills { get; set; }
    public string? TrainerSpecialization { get; set; }
    public string? Summary { get; set; }
    public string? CV { get; set; }
    public List<SubTraining>? SubTraining { get; set; }
}
