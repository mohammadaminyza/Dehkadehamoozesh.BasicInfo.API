using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.Entities;
using M.YZ.Basement.Core.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Description = DehkadehAmoozesh.BasicInfo.API.Core.Domain.Common.ValueObjects.Description;

namespace DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Commands.Tickets.Config;

public class TicketAnswerConfig : IEntityTypeConfiguration<TicketAnswer>
{
    public void Configure(EntityTypeBuilder<TicketAnswer> builder)
    {

        builder.Property(p => p.BusinessId)
            .HasConversion(p => p.Value, p => BusinessId.FromGuid(p))
            .IsRequired();

        builder.Property(p => p.TicketId)
            .HasConversion(p => p.Value, p => BusinessId.FromGuid(p))
            .IsRequired();

        builder.Property(p => p.UserId)
            .HasConversion(p => p.Value, p => BusinessId.FromGuid(p))
            .IsRequired();

        builder.Property(p => p.Text)
            .HasConversion(p => p.Value, p => Description.FromString(p))
            .IsRequired();

        builder.HasOne<Ticket>()
            .WithMany()
            .HasForeignKey(x => x.TicketId)
            .HasPrincipalKey(c => c.BusinessId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}