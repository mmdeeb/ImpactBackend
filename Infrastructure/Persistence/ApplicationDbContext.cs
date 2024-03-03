using Application.Common.Interfaces;
using Domain.Entities;

using Microsoft.EntityFrameworkCore;


namespace ImpactBackend.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
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
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<SupplierAccount> SupplierAccounts { get; set; }
        public DbSet<TrainerAccount> TrainerAccounts { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            // AdditionalCost entity configuration
            modelBuilder.Entity<AdditionalCost>()
                .HasOne(a => a.Training)
                .WithMany(t => t.AdditionalCosts)
                .HasForeignKey(a => a.TraningId)
                .OnDelete(DeleteBehavior.Restrict);

            // Training entity configuration


            modelBuilder.Entity<Training>()
                .HasOne(t => t.Clint)
                .WithMany(c => c.Trainings)
                .HasForeignKey(t => t.ClientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Training>()
                .HasOne(t => t.TrainingInvoice)
                .WithOne(ti => ti.Traning)
                .HasForeignKey<TrainingInvoice>(ti => ti.TraningId);




            // Reservation entity configuration
            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Hall)
                .WithMany(h => h.Reservations)
                .HasForeignKey(r => r.HallId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Client)
                .WithOne(c => c.Reservation)
                .HasForeignKey<Reservation>(r => r.ClientId);

            // Client entity configuration
            modelBuilder.Entity<Client>()
                .HasOne(c => c.Reservation)
                .WithOne(r => r.Client)
                .HasForeignKey<Client>(c => c.ReservationId);

            // Attendance entity configuration
            modelBuilder.Entity<Attendance>()
                .HasMany(a => a.Trainee)
                .WithOne(t => t.Attendance)
                .HasForeignKey(t => t.AttendanceId)
                .OnDelete(DeleteBehavior.Restrict);

            // Hall entity configuration
            modelBuilder.Entity<Hall>()
                .HasOne(h => h.Center)
                .WithMany(c => c.Halls)
                .HasForeignKey(h => h.CenterId)
                .OnDelete(DeleteBehavior.Restrict);

            // LogisticCost entity configuration
            modelBuilder.Entity<LogisticCost>()
                .HasOne(lc => lc.Person)
                .WithMany()
                .HasForeignKey(lc => lc.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<LogisticCost>()
                .HasOne(lc => lc.Center)
                .WithMany()
                .HasForeignKey(lc => lc.CenterId);

            // Employee entity configuration
            modelBuilder.Entity<Employee>()
                .HasOne(h => h.Center)
                .WithMany(c => c.Employees)
                .HasForeignKey(h => h.CenterId)
                .OnDelete(DeleteBehavior.Restrict);

            // ExternalCenter entity configuration
            modelBuilder.Entity<ExternalCenter>()
                .HasMany(ec => ec.ExternalReservations)
                .WithOne(er => er.ExternalCenter)
                .HasForeignKey(er => er.ExternalCenterId)
                .OnDelete(DeleteBehavior.Restrict);

            // ExternalReservation entity configuration
            modelBuilder.Entity<ExternalReservation>()
                .HasMany(er => er.ReservationDays)
                .WithOne(rd => rd.ExternalReservation)
                .HasForeignKey(rd => rd.ExternalReservationId)
                .OnDelete(DeleteBehavior.Restrict);

            // ReservationDay entity configuration
            modelBuilder.Entity<ReservationDay>()
                .HasOne(rd => rd.ExternalReservation)
                .WithMany(er => er.ReservationDays)
                .HasForeignKey(rd => rd.ExternalReservationId)
                .OnDelete(DeleteBehavior.Restrict);

            // TrainingType entity configuration
            modelBuilder.Entity<TrainingType>()
                .HasMany(tt => tt.SubTraining)
                .WithOne(st => st.TrainingType)
                .HasForeignKey(st => st.TrainingTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            // SubTraining entity configuration
            modelBuilder.Entity<SubTraining>()
                .HasMany(st => st.Trainers)
                .WithMany(t => t.SubTraining)
                .UsingEntity<Dictionary<string, object>>(
                    "SubTrainingTrainer",
                    j => j.HasOne<Trainer>().WithMany().HasForeignKey("TrainerId"),
                    j => j.HasOne<SubTraining>().WithMany().HasForeignKey("SubTrainingId"),
                    j =>
                    {
                        j.HasKey("TrainerId", "SubTrainingId");
                        j.ToTable("TrainerSubTraining");
                    });


            // Mail entity configuration
            modelBuilder.Entity<Mail>()
                .HasOne(m => m.Organization)
                .WithMany()
                .HasForeignKey(m => m.UserId)
                .OnDelete(DeleteBehavior.Restrict);



            // RestaurantAccount entity configuration
            modelBuilder.Entity<RestaurantAccount>()
                .HasOne(ra => ra.Restaurant)
                .WithOne(r => r.RestaurantAccount)
                .HasForeignKey<Restaurant>(r => r.RestaurantAccountId);

            // Restaurant entity configuration
            modelBuilder.Entity<Restaurant>()
                .HasOne(r => r.RestaurantAccount)
                .WithOne(ra => ra.Restaurant)
                .HasForeignKey<RestaurantAccount>(ra => ra.Id);

            modelBuilder.Entity<Trainee>()
                .HasOne(t => t.Training)
                .WithMany(t => t.Trainees)
                .HasForeignKey(t => t.TrainingId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<ReceiptFromClient>()
                .HasOne(rfc => rfc.ClientAccount)
                .WithMany(ca => ca.ReceiptsFromClient)
                .HasForeignKey(rfc => rfc.ClientAccountId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ReceiptToEmployee>()
                .HasOne(rte => rte.EmployeeAccount)
                .WithMany(ea => ea.ReceiptToEmployees)
                .HasForeignKey(rte => rte.EmployeeAccountId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<ReceiptToRestaurant>()
                .HasOne(rtr => rtr.RestaurantAccount)
                .WithMany(ea => ea.ReceiptToRestaurants)
                .HasForeignKey(rtr => rtr.RestaurantAccountId)
                .OnDelete(DeleteBehavior.Restrict);



            modelBuilder.Entity<ClientAccount>()
                .HasOne(ca => ca.Client)
                .WithOne(c => c.ClientAccount)
                .HasForeignKey<ClientAccount>(c => c.ClientId);
            modelBuilder.Entity<Client>()
                .HasOne(c => c.ClientAccount)
                .WithOne(ca => ca.Client)
                .HasForeignKey<Client>(c => c.ClientAccountId);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.EmployeeAccount)
                .WithOne(ea => ea.Employee)
                .HasForeignKey<Employee>(e => e.EmployeeAccountId);
            modelBuilder.Entity<EmployeeAccount>()
                .HasOne(ea => ea.Employee)
                .WithOne(e => e.EmployeeAccount)
                .HasForeignKey<EmployeeAccount>(e => e.EmployeeId);



            modelBuilder.Entity<Trainer>()
                .HasOne(t => t.TrainerAccount)
                .WithOne(ta => ta.Trainer)
                .HasForeignKey<Trainer>(t => t.TrainerAccountId);
            modelBuilder.Entity<TrainerAccount>()
                .HasOne(ta => ta.Trainer)
                .WithOne(t => t.TrainerAccount)
                .HasForeignKey<TrainerAccount>(t => t.TrainerId);



            base.OnModelCreating(modelBuilder);

        }

        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
    }
}

