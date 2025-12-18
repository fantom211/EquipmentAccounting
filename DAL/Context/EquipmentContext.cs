using EquipmentDatabase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public partial class EquipmentContext : DbContext
    {
        public EquipmentContext(DbContextOptions<EquipmentContext> options)
        : base(options)
        { }


        public virtual DbSet<Department> Departments { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<Equipment> Equipments { get; set; }

        public virtual DbSet<EquipmentHistory> EquipmentHistories { get; set; }

        public virtual DbSet<EquipmentType> EquipmentTypes { get; set; }

        public virtual DbSet<InstalledSoftware> InstalledSoftwares { get; set; }

        public virtual DbSet<SoftwareLicense> SoftwareLicenses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseSqlServer(AppConfig.connectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Departme__3213E83F79430E32");

                entity.HasOne(d => d.Manager).WithMany(p => p.Departments).HasConstraintName("FK_Department_Manager");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Employee__3213E83FEE1FE2FA");

                entity.HasOne(d => d.Department).WithMany(p => p.Employees).HasConstraintName("FK_Employee_Department");
            });

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Equipmen__3213E83F66CAB620");

                entity.Property(e => e.DateAdded).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Employee).WithMany(p => p.Equipment)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Equipments_Employees");

                entity.HasOne(d => d.Type).WithMany(p => p.Equipment).HasConstraintName("FK_Equipments_Types");
            });

            modelBuilder.Entity<EquipmentHistory>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Equipmen__3213E83FF4E00291");

                entity.Property(e => e.DateMoved).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Equipment).WithMany(p => p.EquipmentHistories).HasConstraintName("FK_Histories_Equipments");

                entity.HasOne(d => d.NewEmployee).WithMany(p => p.EquipmentHistoryNewEmployees).HasConstraintName("FK_Histories_NewEmployee");

                entity.HasOne(d => d.OldEmployee).WithMany(p => p.EquipmentHistoryOldEmployees).HasConstraintName("FK_Histories_OldEmployee");
            });

            modelBuilder.Entity<EquipmentType>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Equipmen__3213E83F68CDF3A1");
            });

            modelBuilder.Entity<InstalledSoftware>(entity =>
            {
                entity.HasKey(e => new { e.EquipmentId, e.LicenseId }).HasName("PK__Installe__036A2593C60DF044");

                entity.Property(e => e.InstallDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Equipment).WithMany(p => p.InstalledSoftwares).HasConstraintName("FK_Installed_Equipments");

                entity.HasOne(d => d.License).WithMany(p => p.InstalledSoftwares).HasConstraintName("FK_Installed_Licenses");
            });

            modelBuilder.Entity<SoftwareLicense>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Software__3214EC27F1CD5D2A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
    
}
