﻿
using ImpactDomain.Common;
using ImpactDomain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ImpactInfrastructure.Persistence;

public class ImpactDbContext : DbContext
{

    public ImpactDbContext(DbContextOptions<ImpactDbContext> options) : base(options)
    {
    }


    public DbSet<AboutUs> AboutUs { get; set; }
    public DbSet<AdditionalCost> AdditionalCosts { get; set; }
    public DbSet<Ads> Ads { get; set; }
    public DbSet<Attendance> Attendance { get; set; }
    public DbSet<Center> Centers { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<ExternalCenter> ExternalCenters { get; set; }
    public DbSet<ExternalReservation> ExternalReservations { get; set; }
    public DbSet<Hall> Halls { get; set; }
    public DbSet<LogisticCost> LogisticCosts { get; set; }
    public DbSet<Mail> Mails { get; set; }
    public DbSet<Paid> Paids { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<ReservationDay> ReservationDays { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<RestaurantAccount> RestaurantAccounts { get; set; }
    public DbSet<SubTraining> SubTrainings { get; set; }
    public DbSet<Trainee> Trainees { get; set; }
    public DbSet<Trainer> Trainers { get; set; }
    public DbSet<Training> Trainings { get; set; }
    public DbSet<TrainingInvoice> TrainingInvoices { get; set; }
    public DbSet<TrainingType> TrainingTypes { get; set; }
    public DbSet<User> Users { get; set; }
 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


        //modelBuilder.Entity<AboutUs>().HasKey(a => a.Id);
        //modelBuilder.Entity<AdditionalCost>().HasKey(ac => ac.Id);
        //modelBuilder.Entity<Ads>().HasKey(a => a.Id);
        //modelBuilder.Entity<Attendance>().HasKey(a => a.Id);
        //modelBuilder.Entity<Center>().HasKey(c => c.Id);
        //modelBuilder.Entity<Client>().HasKey(c => c.Id);
        //modelBuilder.Entity<Employee>().HasKey(e => e.Id);
        //modelBuilder.Entity<ExternalCenter>().HasKey(ec => ec.Id);
        //modelBuilder.Entity<ExternalReservation>().HasKey(er => er.Id);
        //modelBuilder.Entity<Hall>().HasKey(h => h.Id);
        //modelBuilder.Entity<LogisticCost>().HasKey(lc => lc.Id);
        //modelBuilder.Entity<Mail>().HasKey(m=> m.Id);
        //modelBuilder.Entity<Paid>().HasKey(p => p.Id);
        //modelBuilder.Entity<Reservation>().HasKey(r => r.Id);
        //modelBuilder.Entity<ReservationDay>().HasKey(rd => rd.Id);
        //modelBuilder.Entity<Restaurant>().HasKey(e => e.Id);
        //modelBuilder.Entity<RestaurantAccount>().HasKey(ra => ra.Id);
        //modelBuilder.Entity<SubTraining>().HasKey(st => st.Id);
        //modelBuilder.Entity<Trainee>().HasKey(t => t.Id);
        //modelBuilder.Entity<Trainer>().HasKey(t => t.Id);
        //modelBuilder.Entity<Training>().HasKey(t => t.Id);
        //modelBuilder.Entity<TrainingInvoice>().HasKey(ti => ti.Id);
        //modelBuilder.Entity<TrainingType>().HasKey(tt => tt.Id);
        //modelBuilder.Entity<User>().HasKey(u => u.Id);


        // AboutUs entity configuration
        //modelBuilder.Entity<AboutUs>()
        //    .Property(a => a.ContactInfo)
        //    .HasConversion(
        //        v => string.Join(',', v),
        //        v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList());

        //modelBuilder.Entity<AboutUs>()
        //    .Property(a => a.Links)
        //    .HasConversion(
        //        v => string.Join(',', v),
        //        v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList());

        // Ads entity configuration
        //modelBuilder.Entity<Ads>()
        //    .Property(a => a.AdsMedia)
        //    .HasConversion(
        //        v => string.Join(',', v),
        //        v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList());

        // User entity configuration
        modelBuilder.Entity<User>()
            .Property(u => u.Name)
            .IsRequired();

        modelBuilder.Entity<User>()
            .Property(u => u.Email)
            .IsRequired();

        modelBuilder.Entity<User>()
            .Property(u => u.Password)
            .IsRequired();

        modelBuilder.Entity<User>()
            .Property(u => u.UserType)
            .IsRequired();

        // AdditionalCost entity configuration
        modelBuilder.Entity<AdditionalCost>()
            .HasOne(a => a.Training)
            .WithMany(t => t.AdditionalCosts)
            .HasForeignKey(a => a.TraningId)
            .OnDelete(DeleteBehavior.Restrict);

        // Training entity configuration
        modelBuilder.Entity<Training>()
            .HasOne(t => t.Reservation)
            .WithMany(r => r.Trainings)
            .HasForeignKey(t => t.ReservationId)
            .OnDelete(DeleteBehavior.Restrict);

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

        // Paid entity configuration
        modelBuilder.Entity<Paid>()
            .HasOne(p => p.Account)
            .WithMany(ra => ra.Paids)
            .HasForeignKey(p => p.RestaurantAccountId)
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

        base.OnModelCreating(modelBuilder);
    }

}