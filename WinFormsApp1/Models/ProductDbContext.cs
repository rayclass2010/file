using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WinFormsApp1.Models
{
    public partial class ProductDbContext : DbContext
    {
        public ProductDbContext()
        {
        }

        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<產品資料> 產品資料s { get; set; } = null!;
        public virtual DbSet<產品類別> 產品類別s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Desktop\\新增資料夾\\WinFormsApp1\\WinFormsApp1\\bin\\Debug\\net6.0-windows\\dbProduct.mdf;Integrated Security=True;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<產品資料>(entity =>
            {
                entity.HasKey(e => e.產品編號)
                    .HasName("PK__產品資料__66B6314199D003F4");

                entity.ToTable("產品資料");

                entity.Property(e => e.品名)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.說明)
                    .HasMaxLength(250)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<產品類別>(entity =>
            {
                entity.HasKey(e => e.類別編號)
                    .HasName("PK__產品類別__69DFE349BB1AC8A8");

                entity.ToTable("產品類別");

                entity.Property(e => e.類別名稱)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
