namespace ImpactDomain.Entities;

public class Trainer : BaseAuditableEntity
{
    public int TrainerId { get; set; }
    public string TrainerName { get; set; }
    public List<string> skills { get; set; }
    public string TrainerSpecialization { get; set; }
    public string Summary { get; set; }
    public string? CV { get; set; }
    public List<SubTraining> SubTraining { get; set; }
}
