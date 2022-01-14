using DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Queries.Common.Models;
using Microsoft.EntityFrameworkCore;

namespace DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Queries.Common.Contexts
{
    public class BasicInfoQueryDbContext : BaseQueryDbContext
    {
        public BasicInfoQueryDbContext(DbContextOptions options) : base(options)
        {
        }

        #region DbSets

        public virtual DbSet<ApplicationLog> ApplicationLogs { get; set; }
        public virtual DbSet<ParrotTranslation> ParrotTranslations { get; set; }
        public virtual DbSet<WalletTransactionDetail> TransactionDetails { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<TicketAnswer> TicketAnswers { get; set; }
        public virtual DbSet<Field> Fields { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationLog>(entity =>
            {
                entity.ToTable("ApplicationLogs", "log");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<ParrotTranslation>(entity =>
            {
                entity.Property(e => e.Culture).HasMaxLength(5);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.HasIndex(e => e.BusinessId, "AK_Tickets_BusinessId")
                    .IsUnique();

                entity.Property(e => e.Text).IsRequired();

                entity.Property(e => e.Title).IsRequired();
            });

            modelBuilder.Entity<TicketAnswer>(entity =>
            {
                entity.HasIndex(e => e.BusinessId, "AK_TicketAnswers_BusinessId")
                    .IsUnique();

                entity.HasIndex(e => e.TicketId, "IX_TicketAnswers_TicketId");

                entity.Property(e => e.Text).IsRequired();

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.TicketAnswers)
                    .HasPrincipalKey(p => p.BusinessId)
                    .HasForeignKey(d => d.TicketId);
            });

            modelBuilder.Entity<WalletTransactionDetail>(entity =>
            {
                entity.HasIndex(e => e.BusinessId, "AK_TransactionDetails_BusinessId")
                    .IsUnique();

                entity.Property(e => e.Description).HasMaxLength(255);
            });
        }

    }
}