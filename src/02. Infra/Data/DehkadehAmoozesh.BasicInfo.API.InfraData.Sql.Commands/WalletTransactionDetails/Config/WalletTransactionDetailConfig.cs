using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Common.ValueObjects;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.Entities;
using M.YZ.Basement.Core.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Commands.WalletTransactionDetails.Config;

public class WalletTransactionDetailConfig : IEntityTypeConfiguration<WalletTransactionDetail>
{
    public void Configure(EntityTypeBuilder<WalletTransactionDetail> builder)
    {
        builder.Property(p => p.BusinessId)
            .HasConversion(o => o.Value, p => BusinessId.FromGuid(p))
            .IsRequired();

        builder.Property(p => p.UserId)
            .HasConversion(o => o.Value, p => BusinessId.FromGuid(p))
            .IsRequired();

        builder.Property(p => p.Description)
            .HasConversion(o => o.Value, o => Description.FromString(o))
            .HasMaxLength(255);
    }
}