using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CherryBag.Data.DB
{
    public partial class CherryBagContext : DbContext
    {
        public CherryBagContext()
        {
        }

        public CherryBagContext(DbContextOptions<CherryBagContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CityMaster> CityMaster { get; set; }
        public virtual DbSet<OrderItems> OrderItems { get; set; }
        public virtual DbSet<OrderMaster> OrderMaster { get; set; }
        public virtual DbSet<PartyMaster> PartyMaster { get; set; }
        public virtual DbSet<PartyTypeMaster> PartyTypeMaster { get; set; }
        public virtual DbSet<PaymentTypeMaster> PaymentTypeMaster { get; set; }
        public virtual DbSet<ProductMaster> ProductMaster { get; set; }
        public virtual DbSet<StateMaster> StateMaster { get; set; }
        public virtual DbSet<UserAddress> UserAddress { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=CherryBag;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CityMaster>(entity =>
            {
                entity.HasOne(d => d.State)
                    .WithMany(p => p.CityMaster)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_CityMaster_StateMaster");
            });

            modelBuilder.Entity<OrderItems>(entity =>
            {
                entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderItems_OrderMaster");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_OrderItems_OrderItems");
            });

            modelBuilder.Entity<OrderMaster>(entity =>
            {
                entity.Property(e => e.OrderTotal).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Party)
                    .WithMany(p => p.OrderMaster)
                    .HasForeignKey(d => d.PartyId)
                    .HasConstraintName("FK_OrderMaster_PartyMaster");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.OrderMaster)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .HasConstraintName("FK_OrderMaster_PaymentTypeMaster");
            });

            modelBuilder.Entity<PartyMaster>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber).HasMaxLength(20);

                entity.HasOne(d => d.PartyType)
                    .WithMany(p => p.PartyMaster)
                    .HasForeignKey(d => d.PartyTypeId)
                    .HasConstraintName("FK_PartyMaster_PartyMaster");
            });

            modelBuilder.Entity<PartyTypeMaster>(entity =>
            {
                entity.Property(e => e.PartyTypeName).HasMaxLength(100);
            });

            modelBuilder.Entity<ProductMaster>(entity =>
            {
                entity.Property(e => e.PurchasePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalePrice).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<UserAddress>(entity =>
            {
                entity.Property(e => e.IsPrimary).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.UserAddress)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_UserAddress_CityMaster");

                entity.HasOne(d => d.Party)
                    .WithMany(p => p.UserAddress)
                    .HasForeignKey(d => d.PartyId)
                    .HasConstraintName("FK_UserAddress_PartyMaster");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
