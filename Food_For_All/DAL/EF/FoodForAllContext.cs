using System;
using System.Collections.Generic;
using DAL.EF.Tables;
using Microsoft.EntityFrameworkCore;

namespace DAL.EF;

public partial class FoodForAllContext : DbContext
{
    public FoodForAllContext()
    {
    }

    public FoodForAllContext(DbContextOptions<FoodForAllContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CollectRequest> CollectRequests { get; set; }

    public virtual DbSet<Distribution> Distributions { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Restaurent> Restaurents { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DbConn");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CollectRequest>(entity =>
        {
            entity.ToTable("CollectRequest");

            entity.Property(e => e.FoodDetails).HasMaxLength(50);
            entity.Property(e => e.MaxPreserveTime)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.RequestTime).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.Employee).WithMany(p => p.CollectRequests)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_CollectRequest_Employee");

            entity.HasOne(d => d.Restaurent).WithMany(p => p.CollectRequests)
                .HasForeignKey(d => d.RestaurentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CollectRequest_Restaurent");
        });

        modelBuilder.Entity<Distribution>(entity =>
        {
            entity.ToTable("Distribution");

            entity.Property(e => e.Location).HasMaxLength(50);

            entity.HasOne(d => d.Employee).WithMany(p => p.Distributions)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Distribution_Distribution");

            entity.HasOne(d => d.Request).WithMany(p => p.Distributions)
                .HasForeignKey(d => d.RequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Distribution_CollectRequest");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.ToTable("Employee");

            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Restaurent>(entity =>
        {
            entity.ToTable("Restaurent");

            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
