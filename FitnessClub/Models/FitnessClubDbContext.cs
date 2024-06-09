using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FitnessClub.Models
{
    public partial class FitnessClubDbContext : DbContext
    {
        private static FitnessClubDbContext dbContext;
        public static FitnessClubDbContext DbContext
        {
            get
            {
                if (dbContext == null)
                {
                    dbContext = new FitnessClubDbContext();
                }
                return dbContext;
            }
        }

        public FitnessClubDbContext()
        {
        }

        public FitnessClubDbContext(DbContextOptions<FitnessClubDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Room> Rooms { get; set; } = null!;
        public virtual DbSet<Trainer> Trainers { get; set; } = null!;
        public virtual DbSet<TrainerAchievement> TrainerAchievements { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Workout> Workouts { get; set; } = null!;
        public virtual DbSet<WorkoutType> WorkoutTypes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-JKVTPGB\\SQLEXPRESS;Initial Catalog=FitnessClub;Integrated Security=True;Encrypt=True;TrustServerCertificate=True").UseLazyLoadingProxies();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Client");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Photo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Client)
                    .HasForeignKey<Client>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Client_User");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.ToTable("Room");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Trainer>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Trainer");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Photo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorkStartDate).HasColumnType("date");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Trainer)
                    .HasForeignKey<Trainer>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Trainer_User");
            });

            modelBuilder.Entity<TrainerAchievement>(entity =>
            {
                entity.ToTable("TrainerAchievement");

                entity.Property(e => e.Achievement)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Trainer)
                    .WithMany(p => p.TrainerAchievements)
                    .HasForeignKey(d => d.TrainerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainerAchievement_Trainer");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.HasIndex(e => e.Login, "UN_User")
                    .IsUnique();

                entity.Property(e => e.Birthdate).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Patronymic)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SecondName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Role");
            });

            modelBuilder.Entity<Workout>(entity =>
            {
                entity.ToTable("Workout");

                entity.Property(e => e.DateWorkout).HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Workouts)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Workout_Room");

                entity.HasOne(d => d.Trainer)
                    .WithMany(p => p.Workouts)
                    .HasForeignKey(d => d.TrainerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Workout_Trainer");

                entity.HasOne(d => d.WorkoutType)
                    .WithMany(p => p.Workouts)
                    .HasForeignKey(d => d.WorkoutTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Workout_WorkoutType");

                entity.HasMany(d => d.Clients)
                    .WithMany(p => p.Workouts)
                    .UsingEntity<Dictionary<string, object>>(
                        "WorkoutClient",
                        l => l.HasOne<Client>().WithMany().HasForeignKey("ClientId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_WorkoutClient_Client"),
                        r => r.HasOne<Workout>().WithMany().HasForeignKey("WorkoutId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_WorkoutClient_Workout"),
                        j =>
                        {
                            j.HasKey("WorkoutId", "ClientId");

                            j.ToTable("WorkoutClient");
                        });
            });

            modelBuilder.Entity<WorkoutType>(entity =>
            {
                entity.ToTable("WorkoutType");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Photo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
