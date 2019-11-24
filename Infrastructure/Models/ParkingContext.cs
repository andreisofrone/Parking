using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Infrastructure.Models
{
    public partial class ParkingContext : DbContext
    {
        public ParkingContext()
        {
        }

        public ParkingContext(DbContextOptions<ParkingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Errors> Errors { get; set; }
        public virtual DbSet<ParkingSlots> ParkingSlots { get; set; }
        public virtual DbSet<Reservations> Reservations { get; set; }
        public virtual DbSet<Rolles> Rolles { get; set; }
        public virtual DbSet<UserLogs> UserLogs { get; set; }
        public virtual DbSet<UserRolles> UserRolles { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-94M20HI\\SQLEXPRESS;Database=Parking;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Errors>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<ParkingSlots>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Reservations>(entity =>
            {
                entity.Property(e => e.DateCompletion).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.ParkingSlot)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.ParkingSlotId)
                    .HasConstraintName("FK_Reservations_ParkingSlots");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Reservations_Users");
            });

            modelBuilder.Entity<Rolles>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<UserLogs>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCompletion).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Reason).HasMaxLength(255);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.UserLogs)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserLogs_Users");
            });

            modelBuilder.Entity<UserRolles>(entity =>
            {
                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRolles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_UserRolles_Rolles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRolles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserRolles_Users");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.CarNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.RefreshToken).HasMaxLength(512);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
