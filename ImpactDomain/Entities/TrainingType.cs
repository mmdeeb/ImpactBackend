namespace ImpactDomain.Entities; 

public class TrainingType : BaseAuditableEntity
{
    public int TrainingTypeId { get; set; }
    public string TrainingTypeName { get; set; }
    public List<SubTraining> subTraining { get; set; }
}
