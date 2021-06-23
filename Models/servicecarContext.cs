using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace serviceCar.Models.DbModels
{
    public partial class servicecarContext : DbContext
    {
        public servicecarContext()
        {
        }

        public servicecarContext(DbContextOptions<servicecarContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Conductor> Conductor { get; set; }
        public virtual DbSet<Efmigrationshistory> Efmigrationshistory { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<VehicleAccident> VehicleAccident { get; set; }
        public virtual DbSet<VehicleBreakdown> VehicleBreakdown { get; set; }
        public virtual DbSet<VehicleBuyContract> VehicleBuyContract { get; set; }
        public virtual DbSet<VehicleFuel> VehicleFuel { get; set; }
        public virtual DbSet<VehicleGeneralInfo> VehicleGeneralInfo { get; set; }
        public virtual DbSet<VehicleMaintenancePlan> VehicleMaintenancePlan { get; set; }
        public virtual DbSet<VehicleReparation> VehicleReparation { get; set; }
        public virtual DbSet<VehicleServices> VehicleServices { get; set; }
        public virtual DbSet<VehicleSpending> VehicleSpending { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Server=localhost;Port=3307;User=root;Password=;Database=servicecar");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Conductor>(entity =>
            {
                entity.HasKey(e => e.User)
                    .HasName("PRIMARY");

                entity.ToTable("conductor");

                entity.Property(e => e.User)
                    .HasColumnName("user")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasColumnName("adress")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Cin)
                    .IsRequired()
                    .HasColumnName("cin")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.TelephoneNumber)
                    .HasColumnName("telephone_number")
                    .HasColumnType("int(10)");

                entity.HasOne(d => d.UserNavigation)
                    .WithOne(p => p.Conductor)
                    .HasForeignKey<Conductor>(d => d.User)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("conductor_ibfk_1");
            });

            modelBuilder.Entity<Efmigrationshistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.ToTable("__efmigrationshistory");

                entity.Property(e => e.MigrationId).HasColumnType("varchar(95)");

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasColumnType("varchar(32)");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PRIMARY");

                entity.ToTable("user");

                entity.Property(e => e.IdUser)
                    .HasColumnName("id_user")
                    .HasColumnType("int(5)");

                entity.Property(e => e.FName)
                    .IsRequired()
                    .HasColumnName("f_name")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.IsAdmin)
                    .HasColumnName("is_admin")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.LName)
                    .IsRequired()
                    .HasColumnName("l_name")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(64)");
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.HasKey(e => e.IdVehicle)
                    .HasName("PRIMARY");

                entity.ToTable("vehicle");

                entity.HasIndex(e => e.VehicleConductor)
                    .HasName("vehicle_conductor");

                entity.Property(e => e.IdVehicle)
                    .HasColumnName("id_vehicle")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.Img)
                    .IsRequired()
                    .HasColumnName("img")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.InUse)
                    .HasColumnName("in_use")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.VehicleConductor)
                    .HasColumnName("vehicle_conductor")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.VehicleConductorNavigation)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.VehicleConductor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vehicle_ibfk_1");
            });

            modelBuilder.Entity<VehicleAccident>(entity =>
            {
                entity.HasKey(e => e.IdVehicleAc)
                    .HasName("PRIMARY");

                entity.ToTable("vehicle_accident");

                entity.Property(e => e.IdVehicleAc)
                    .HasColumnName("id_vehicle_ac")
                    .HasColumnType("int(5)");

                entity.Property(e => e.DamageDescription)
                    .IsRequired()
                    .HasColumnName("damage_description")
                    .HasColumnType("text");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.WasInsured)
                    .HasColumnName("was_insured")
                    .HasColumnType("bit(1)");

                entity.HasOne(d => d.IdVehicleAcNavigation)
                    .WithOne(p => p.VehicleAccident)
                    .HasForeignKey<VehicleAccident>(d => d.IdVehicleAc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vehicle_accident_ibfk_1");
            });

            modelBuilder.Entity<VehicleBreakdown>(entity =>
            {
                entity.HasKey(e => e.IdBreakdown)
                    .HasName("PRIMARY");

                entity.ToTable("vehicle_breakdown");

                entity.HasIndex(e => e.IdVehicleBd)
                    .HasName("id_vehicle_bd");

                entity.Property(e => e.IdBreakdown)
                    .HasColumnName("id_breakdown")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.IdVehicleBd)
                    .HasColumnName("id_vehicle_bd")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Problem)
                    .IsRequired()
                    .HasColumnName("problem")
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.IdVehicleBdNavigation)
                    .WithMany(p => p.VehicleBreakdown)
                    .HasForeignKey(d => d.IdVehicleBd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vehicle_breakdown_ibfk_1");
            });

            modelBuilder.Entity<VehicleBuyContract>(entity =>
            {
                entity.HasKey(e => e.IdVehicleBc)
                    .HasName("PRIMARY");

                entity.ToTable("vehicle_buy_contract");

                entity.Property(e => e.IdVehicleBc)
                    .HasColumnName("id_vehicle_bc")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.BuyDate)
                    .HasColumnName("buy_date")
                    .HasColumnType("date");

                entity.Property(e => e.ContractNumber)
                    .HasColumnName("contract_number")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Provider)
                    .HasColumnName("provider")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Tva)
                    .HasColumnName("tva")
                    .HasColumnType("decimal(2,2)");

                entity.Property(e => e.WarrantyYears)
                    .HasColumnName("warranty_years")
                    .HasColumnType("int(2)");

                entity.HasOne(d => d.IdVehicleBcNavigation)
                    .WithOne(p => p.VehicleBuyContract)
                    .HasForeignKey<VehicleBuyContract>(d => d.IdVehicleBc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vehicle_buy_contract_ibfk_1");
            });

            modelBuilder.Entity<VehicleFuel>(entity =>
            {
                entity.HasKey(e => e.IdSpFu)
                    .HasName("PRIMARY");

                entity.ToTable("vehicle_fuel");

                entity.Property(e => e.IdSpFu)
                    .HasColumnName("id_sp_fu")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("decimal(10,2)");

                entity.HasOne(d => d.IdSpFuNavigation)
                    .WithOne(p => p.VehicleFuel)
                    .HasForeignKey<VehicleFuel>(d => d.IdSpFu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vehicle_fuel_ibfk_1");
            });

            modelBuilder.Entity<VehicleGeneralInfo>(entity =>
            {
                entity.HasKey(e => e.IdVehicleGi)
                    .HasName("PRIMARY");

                entity.ToTable("vehicle_general_info");

                entity.Property(e => e.IdVehicleGi)
                    .HasColumnName("id_vehicle_gi")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Acquisition)
                    .IsRequired()
                    .HasColumnName("acquisition")
                    .HasColumnType("enum('ACHAT')");

                entity.Property(e => e.BodyType)
                    .IsRequired()
                    .HasColumnName("body_type")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.ChassisNumber)
                    .IsRequired()
                    .HasColumnName("chassis_number")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FuelType)
                    .IsRequired()
                    .HasColumnName("fuel_type")
                    .HasColumnType("enum('DIESEL','ESSENCE','HYBRIDE','ELECTRIQUE')");

                entity.Property(e => e.GreyCard)
                    .IsRequired()
                    .HasColumnName("grey_card")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.InUseYr)
                    .HasColumnName("in_use_yr")
                    .HasColumnType("int(4)");

                entity.Property(e => e.Km)
                    .HasColumnName("km")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mark)
                    .IsRequired()
                    .HasColumnName("mark")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.MatriculNumber)
                    .IsRequired()
                    .HasColumnName("matricul_number")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasColumnName("model")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ModelYear)
                    .HasColumnName("model_year")
                    .HasColumnType("int(4)");

                entity.Property(e => e.VehicleType)
                    .IsRequired()
                    .HasColumnName("vehicle_type")
                    .HasColumnType("enum('Voiture','Camion')");

                entity.HasOne(d => d.IdVehicleGiNavigation)
                    .WithOne(p => p.VehicleGeneralInfo)
                    .HasForeignKey<VehicleGeneralInfo>(d => d.IdVehicleGi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vehicle_general_info_ibfk_1");
            });

            modelBuilder.Entity<VehicleMaintenancePlan>(entity =>
            {
                entity.HasKey(e => e.IdVehicleMp)
                    .HasName("PRIMARY");

                entity.ToTable("vehicle_maintenance_plan");

                entity.Property(e => e.IdVehicleMp)
                    .HasColumnName("id_vehicle_mp")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.HasOne(d => d.IdVehicleMpNavigation)
                    .WithOne(p => p.VehicleMaintenancePlan)
                    .HasForeignKey<VehicleMaintenancePlan>(d => d.IdVehicleMp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vehicle_maintenance_plan_ibfk_1");
            });

            modelBuilder.Entity<VehicleReparation>(entity =>
            {
                entity.HasKey(e => e.IdVehicleRe)
                    .HasName("PRIMARY");

                entity.ToTable("vehicle_reparation");

                entity.Property(e => e.IdVehicleRe)
                    .HasColumnName("id_vehicle_re")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdVehicleReNavigation)
                    .WithOne(p => p.VehicleReparation)
                    .HasForeignKey<VehicleReparation>(d => d.IdVehicleRe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vehicle_reparation_ibfk_1");
            });

            modelBuilder.Entity<VehicleServices>(entity =>
            {
                entity.HasKey(e => e.IdVehicleSe)
                    .HasName("PRIMARY");

                entity.ToTable("vehicle_services");

                entity.Property(e => e.IdVehicleSe)
                    .HasColumnName("id_vehicle_se")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Km)
                    .HasColumnName("km")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(20)");

                entity.HasOne(d => d.IdVehicleSeNavigation)
                    .WithOne(p => p.VehicleServices)
                    .HasForeignKey<VehicleServices>(d => d.IdVehicleSe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vehicle_services_ibfk_1");
            });

            modelBuilder.Entity<VehicleSpending>(entity =>
            {
                entity.HasKey(e => e.IdSp)
                    .HasName("PRIMARY");

                entity.ToTable("vehicle_spending");

                entity.HasIndex(e => e.IdConductorSp)
                    .HasName("id_conductor_sp");

                entity.HasIndex(e => e.IdVehicleSp)
                    .HasName("id_vehicle_sp");

                entity.Property(e => e.IdSp)
                    .HasColumnName("id_sp")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.DateSp)
                    .HasColumnName("date_sp")
                    .HasColumnType("date");

                entity.Property(e => e.IdConductorSp)
                    .HasColumnName("id_conductor_sp")
                    .HasColumnType("int(5)");

                entity.Property(e => e.IdVehicleSp)
                    .HasColumnName("id_vehicle_sp")
                    .HasColumnType("int(5)");

                entity.Property(e => e.TimeSp)
                    .HasColumnName("time_sp")
                    .HasColumnType("time");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(20)");

                entity.HasOne(d => d.IdConductorSpNavigation)
                    .WithMany(p => p.VehicleSpending)
                    .HasForeignKey(d => d.IdConductorSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vehicle_spending_ibfk_2");

                entity.HasOne(d => d.IdVehicleSpNavigation)
                    .WithMany(p => p.VehicleSpending)
                    .HasForeignKey(d => d.IdVehicleSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vehicle_spending_ibfk_1");
            });
        }

        internal void SaveChanges(int user)
        {
            throw new NotImplementedException();
        }

        internal object FromSqlInterpolated(string v)
        {
            throw new NotImplementedException();
        }
    }
}
