namespace Domain.Entities;
public class Client : BaseAuditableEntity
{
    public string? ClinetName { get; set; }
    public string? PhoneNumber { get; set;}
    public double Amount { get; set;}
    public string? Email { get; set;}
    public Reservation? Reservation { get; set;}
    public int ReservationId { get; set; }
    public List<Training>? Trainings { get; set; }
}


