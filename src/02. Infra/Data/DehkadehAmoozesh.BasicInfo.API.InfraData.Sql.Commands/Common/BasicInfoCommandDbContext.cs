﻿using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.Entities;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.Entities;
using M.YZ.Basement.Infra.Data.Sql.Commands;
using Microsoft.EntityFrameworkCore;

namespace DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Commands.Common;

public class BasicInfoCommandDbContext : BaseCommandDbContext
{
    #region Constructors
    public BasicInfoCommandDbContext(DbContextOptions<BasicInfoCommandDbContext> options) : base(options)
    {
    }

    public BasicInfoCommandDbContext()
    {
    }
    #endregion

    #region DbSets

    public DbSet<WalletTransactionDetail> TransactionDetails { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<TicketAnswer> TicketAnswers { get; set; }

    #endregion

    #region overrides

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }

    #endregion
}