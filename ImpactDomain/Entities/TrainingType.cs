namespace ImpactDomain.Entities; 

public class TrainingType : BaseAuditableEntity
{
    public int TrainingTypeId { get; set; }
    public string TrainingTypeName { get; set; }
    public List<SubTraining> SubTraining { get; set; }
}
