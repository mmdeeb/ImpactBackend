namespace Domain.Entities;

public class ClientAccount : BaseAuditableEntity
{
    public Client? Client { get; set; }
    public int ClientId { get; set; }
    public List<Training>? Trainings { get; set; }
    public double Discount { get; set; }
    public List<ReceiptFromClient>? ReceiptsFromClient { get; set; }
    public double TotalBalance { get; set; }
    public double Debt { get; set; }
}
