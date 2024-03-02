namespace Domain.Entities;

public class TrainingInvoice : BaseAuditableEntity
{
    public Training? Traning { get; set; }
    public int TraningId { get; set; }
    public Client? Client { get; set; }
    public int ClientId { get; set; }
    public Center? Center { get; set; }
    public int CenterId { get; set; }
    public List<AdditionalCost>? AdditionalCosts { get; set; }
    public List<LogisticCost>? LogisticCosts { get; set; }
    public List<Mail> Meals { get; set; }
    public double MealsCost { get; set; }
    public Trainer? Trainer { get; set; }
    public double TrainerCost { get; set; }
    public string? PhotoInvoiceURL { get; set; }
    public Reservation Reservation { get; set; }
    public double ReservationsCost { get; set; }
    public double TotalCost { get; set; }
    public double Discount { get; set; }
    public double FinalCost { get; set; }
}
