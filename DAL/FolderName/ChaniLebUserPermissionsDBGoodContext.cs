using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.FolderName
{
    public partial class ChaniLebUserPermissionsDBGoodContext : DbContext
    {
        public ChaniLebUserPermissionsDBGoodContext()
        {
        }

        public ChaniLebUserPermissionsDBGoodContext(DbContextOptions<ChaniLebUserPermissionsDBGoodContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Permission> Permissions { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=SQL-KITOTBB\\TICHNUT;Initial Catalog=ChaniLebUserPermissionsDBGood;Integrated Security=True;Encrypt=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permission>(entity =>
            {
                entity.HasIndex(e => e.PermissionName, "UQ__Permissi__0FFDA357EACD669D")
                    .IsUnique();

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.PermissionName).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.UserName, "UQ__Users__C9F28456067A6C7A")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.PasswordHash).HasMaxLength(256);

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.PermissionId)
                    .HasConstraintName("FK__Users__Permissio__3C69FB99");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
