
namespace Domain.Entities;

public class TrainerAccount : BaseAuditableEntity
{
    public Trainer? Trainer { get; set; } 
    public int TrainerId { get; set; } 
    public List<Training>? Trainings { get; set; }
    public double TotalBalance { get; set; }
    public double Debt { get; set; }
  //  public List<Receipt>? Receipts { get; set; }
}
