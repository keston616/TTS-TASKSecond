using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ApiForTestWork.Entities;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Image> Images { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Image>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("images");

            entity.HasIndex(e => e.FromId, "FromId_idx");

            entity.HasIndex(e => e.ToId, "ToId_idx");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.HasOne(d => d.From).WithMany(p => p.ImageFroms)
                .HasForeignKey(d => d.FromId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FromId");

            entity.HasOne(d => d.To).WithMany(p => p.ImageTos)
                .HasForeignKey(d => d.ToId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("ToId");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("user");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Login)
                .HasMaxLength(45)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(45)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(45)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
