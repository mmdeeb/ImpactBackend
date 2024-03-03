namespace Domain.Entities;
public class Client : User
{
    public Reservation? Reservation { get; set;}
    public int ReservationId { get; set; }
    public List<Training>? Trainings { get; set; }
    public ClientAccount? ClientAccount { get; set; }
    public int ClientAccountId { get; set; }
}


