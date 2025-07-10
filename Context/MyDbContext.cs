using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WinFormsApp2.Entities;

namespace WinFormsApp2.Context
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeeDepartment> EmployeeDepartments { get; set; } = null!;
        public virtual DbSet<EmployeeView> EmployeeViews { get; set; } = null!;
        public virtual DbSet<Ticket> Tickets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=ITSPECIALIST1\\MSSQLSERVER07;Database=hrisdemo;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("department");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("date_of_birth");

                entity.Property(e => e.DeleteAt)
                    .HasColumnType("datetime")
                    .HasColumnName("delete_at");

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employee_code");

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("full_name");
            });

            modelBuilder.Entity<EmployeeDepartment>(entity =>
            {
                entity.ToTable("employee_department");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.EmployeeDepartments)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__employee___depar__403A8C7D");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeDepartments)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__employee___emplo__3F466844");
            });

            modelBuilder.Entity<EmployeeView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EmployeeView");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("department_name");

                entity.Property(e => e.EmployeeDateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("employee_date_of_birth");

                entity.Property(e => e.EmployeeFullName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employee_full_name");

                entity.Property(e => e.EmployeeGenerateCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employee_generate_code");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.ToTable("ticket");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Concern)
                    .HasColumnType("text")
                    .HasColumnName("concern");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ticket__departme__412EB0B6");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ticket__employee__4222D4EF");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
