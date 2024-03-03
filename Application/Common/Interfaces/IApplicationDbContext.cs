using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces
{
	public interface IApplicationDbContext
	{
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<AdditionalCost> AdditionalCosts { get; set; }
        public DbSet<Ads> Ads { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<Center> Centers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientAccount> ClientAccounts { get; set; }
        public DbSet<ReceiptFromClient> ReceiptFromClients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeAccount> EmployeeAccounts { get; set; }
        public DbSet<ReceiptToEmployee> ReceiptToEmploye { get; set; }
        public DbSet<ExternalCenter> ExternalCenters { get; set; }
        public DbSet<ExternalReservation> ExternalReservations { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<LogisticCost> LogisticCosts { get; set; }
        public DbSet<Mail> Mails { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationDay> ReservationDays { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantAccount> RestaurantAccounts { get; set; }
        public DbSet<ReceiptToRestaurant> ReceiptToRestaurants { get; set; }
        public DbSet<SubTraining> SubTrainings { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<TrainingInvoice> TrainingInvoices { get; set; }
        public DbSet<TrainingType> TrainingTypes { get; set; }
        public DbSet<OtherExpenses> OtherExpenses { get; set; }
        public DbSet<Receipt> Receipts  { get; set; }
        public DbSet<SupplierAccount> SupplierAccounts { get; set; }
        public DbSet<TrainerAccount> TrainerAccounts { get; set; }
        public DbSet<User> Users { get; set; }

        Task<int> SaveChangesAsync();
	}
}