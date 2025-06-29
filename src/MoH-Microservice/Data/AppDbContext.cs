﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MoH_Microservice.Models.Database;

namespace MoH_Microservice.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<PaymentChannel> PaymentChannels { get; set; }
        public DbSet<PaymentPurpose> PaymentPurposes { get; set; }
        public DbSet<PCollections> PaymentCollections { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientAddress> PatientAddress { get; set; }
        public DbSet<PatientAccedent> PatientAccedents { get; set; }
        public DbSet<PatientRequestedServices> PatientRequestedServices { get; set; }
        public DbSet<Providers> Providers { get; set; }
        public DbSet<ProvidersMapUsers> ProvidersMapPatient { get; set; }
        public DbSet<Organiztion> Organiztions { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<PaymentCollectors> PaymentCollectors { get; set; }
        public DbSet<OrganiztionalUsers> OrganiztionalUsers { get; set; }
        public DbSet<GroupSetting> groupSettings { get; set; }
        public DbSet<UserSetting> userSettings { get; set; }
        public DbSet<PaymentTypeDiscription> PaymentTypeDiscriptions { get; set; }
        public DbSet<PaymentTypeLimit> PaymentPurposeLimits { get; set; }
        public DbSet<NurseRequest> NurseRequests { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<ReportFilters> ReportFilters { get; set; }
        public DbSet<ReportStore> ReportStore { get; set; }
        public DbSet<ReportAccess> ReportAccess { get; set; }
        public DbSet<ReportSource> ReportSource { get; set; }
        public DbSet<DoctorRequest> DoctorRequests { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id="1",Name="Admin",NormalizedName="ADMIN"},
                new IdentityRole { Id = "2", Name = "User", NormalizedName = "USER" }

                );

            //Seed Admin Data
            var hasher = new PasswordHasher<AppUser>();
            var adminUser = new AppUser
            {
                UserName = "DerejeH",
                NormalizedUserName = "DEREJEH",
                Email = "dereje.hmariam@tsedeybank.com.et",
                NormalizedEmail = "DEREJE.HMARIAM@TSEDEYBANK.COM.ET",
                PhoneNumber = "+251912657147",
                EmailConfirmed = true,
                UserType = "Admin",
                Departement = "Tsedey Bank",
                PhoneNumberConfirmed = true,
                LockoutEnabled = false,
            };

            adminUser.PasswordHash = hasher.HashPassword(adminUser, "Dereje@Tsedeybank");


            builder.Entity<AppUser>().HasData(adminUser);


            //Assign Role To Admin
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1",
                    UserId = adminUser.Id
                }
                );

            builder.Entity<Payment>().HasIndex("RefNo", "CreatedBy").IsUnique(false);
            builder.Entity<Payment>().HasIndex("RefNo").IsUnique(false);
            builder.Entity<Payment>().HasIndex("CreatedBy").IsUnique(false);

            builder.Entity<Patient>().HasIndex("MRN").IsUnique(true);
            builder.Entity<Patient>().HasIndex("phonenumber").IsUnique(false);

            builder.Entity<PatientAddress>().HasIndex("MRN").IsUnique(false);
            builder.Entity<PatientAddress>().HasIndex("REFMRN").IsUnique(false);


            builder.Entity<PatientRequestedServices>().HasIndex("MRN").IsUnique(false);
            builder.Entity<PatientRequestedServices>().HasIndex("groupId").IsUnique(false);
            builder.Entity<PatientRequestedServices>().HasIndex("isPaid").IsUnique(false);
            builder.Entity<PatientRequestedServices>().HasIndex("purpose").IsUnique(false);
            builder.Entity<PatientRequestedServices>().HasIndex("isComplete").IsUnique(false);

            builder.Entity<Patient>().HasIndex("firstName").IsUnique(false);
            builder.Entity<Patient>().HasIndex("middleName").IsUnique(false);
            builder.Entity<Patient>().HasIndex("lastName").IsUnique(false);

            builder.Entity<PCollections>().HasKey("CollectionId");

            builder.Entity<PaymentType>().HasData(
                 new PaymentType { Id = 1, type = "ALL", CreatedBy = "SYS", CreatedOn = DateTime.Now },
                 new PaymentType { Id = 2, type = "CASH", CreatedBy = "SYS", CreatedOn = DateTime.Now}
                , new PaymentType { Id = 3, type = "CBHI", CreatedBy = "SYS", CreatedOn = DateTime.Now }
                , new PaymentType { Id = 4, type = "Credit", CreatedBy = "SYS", CreatedOn = DateTime.Now }
                , new PaymentType { Id = 5, type = "Free of Charge", CreatedBy = "SYS", CreatedOn = DateTime.Now }
                , new PaymentType { Id = 6, type = "Digital", CreatedBy = "SYS", CreatedOn = DateTime.Now }
                );

            builder.Entity<PaymentPurpose>().HasData(
                  new PaymentPurpose { Id = 1, Purpose = "Card/ካርድ", CreatedBy = "SYS", CreatedOn = DateTime.Now }
                , new PaymentPurpose { Id = 2, Purpose = "Medicne/መድሃኒት", CreatedBy = "SYS", CreatedOn = DateTime.Now }
                , new PaymentPurpose { Id = 3, Purpose = "Laboratory/ላብራቶሪ", CreatedBy = "SYS", CreatedOn = DateTime.Now }
                , new PaymentPurpose { Id = 4, Purpose = "Rag/X-RAY/ራጅ፣አልትራሳውንድ", CreatedBy = "SYS", CreatedOn = DateTime.Now }
                , new PaymentPurpose { Id = 5, Purpose = "Others/ሌሎች", CreatedBy = "SYS", CreatedOn = DateTime.Now }
                );

            builder.Entity<PaymentChannel>().HasData(
                     
                      new PaymentChannel { Id = 1, Channel = "TeleBirr", CreatedBy = "SYS", CreatedOn = DateTime.Now }
                    , new PaymentChannel { Id = 2, Channel = "CBE Mobile Banking", CreatedBy = "SYS", CreatedOn = DateTime.Now }
                    , new PaymentChannel { Id = 3, Channel = "Awash Bank", CreatedBy = "SYS", CreatedOn = DateTime.Now }
                    , new PaymentChannel { Id = 4, Channel = "Bank of Abyssinia", CreatedBy = "SYS", CreatedOn = DateTime.Now }
                    , new PaymentChannel { Id = 5, Channel = "Amhara Bank", CreatedBy = "SYS", CreatedOn = DateTime.Now }
                    , new PaymentChannel { Id = 6, Channel = "Tsedey Bank", CreatedBy = "SYS", CreatedOn = DateTime.Now }
                    , new PaymentChannel { Id = 7, Channel = "Other", CreatedBy = "SYS", CreatedOn = DateTime.Now }
                    , new PaymentChannel { Id = 8, Channel = "Chapa", CreatedBy = "SYS", CreatedOn = DateTime.Now }
                );

            builder.HasSequence<long>("patient_card_number")
                .HasMin(1)
                .StartsAt(1)
                .IncrementsBy(1)
                .HasMax(long.MaxValue)
                .IsCyclic(true);

            builder.HasSequence<long>("rapyment_recipt_number")
                .HasMin(1)
                .StartsAt(1)
                .IncrementsBy(1)
                .HasMax(9999999)
                .IsCyclic(true);
        }
    }
}
