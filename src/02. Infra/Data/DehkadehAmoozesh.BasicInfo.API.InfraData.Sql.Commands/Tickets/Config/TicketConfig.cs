using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Tickets.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using M.YZ.Basement.Core.Domain.Toolkits.ValueObjects;
using M.YZ.Basement.Core.Domain.ValueObjects;
using Description = DehkadehAmoozesh.BasicInfo.API.Core.Domain.Common.ValueObjects.Description;

namespace DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Commands.Tickets.Config;

public class TicketConfig : IEntityTypeConfiguration<Ticket>
{
    public void Configure(EntityTypeBuilder<Ticket> builder)
    {
        builder.Property(p => p.BusinessId)
            .HasConversion(p => p.Value, p => BusinessId.FromGuid(p))
            .IsRequired();

        builder.Property(p => p.UserId)
            .HasConversion(p => p.Value, p => BusinessId.FromGuid(p))
            .IsRequired();

        builder.Property(p => p.Title)
            .HasConversion(p => p.Value, p => Title.FromString(p))
            .IsRequired();

        builder.Property(p => p.Text)
            .HasConversion(p => p.Value, p => Description.FromString(p))
            .IsRequired();


        builder.HasMany(t => t.TicketAnswers)
            .WithOne(t => t.Ticket)
            .HasForeignKey(t => t.TicketId)
            .HasPrincipalKey(t => t.BusinessId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}