using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.WalletTransactionDetails.Enums;
using System;
using M.YZ.Basement.Core.Domain.Events;

namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.WalletTransactionDetails.Events;

public class WalletTransactionDetailCreated : IDomainEvent
{
    #region Properties

    public Guid BusinessId { get; set; }
    public string Description { get; set; }
    public Guid UserId { get; set; }
    public WalletTransactionType TransactionTypeId { get; set; }

    #endregion

    #region Ctor

    public WalletTransactionDetailCreated(Guid businessId, string description, Guid userId, WalletTransactionType transactionTypeId)
    {
        BusinessId = businessId;
        Description = description;
        UserId = userId;
        TransactionTypeId = transactionTypeId;
    }

    #endregion

}