﻿using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.WalletTransactionDetails.Enums;
using M.YZ.Basement.Core.Domain.Events;

namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.WalletTransactionDetails.Events;

public class WalletTransactionDetailUpdated : IDomainEvent
{

    #region Properties

    public Guid BusinessId { get; set; }
    public Guid UserId { get; set; }
    public string Description { get; set; }
    public WalletTransactionType TransactionTypeId { get; set; }

    #endregion

    #region Ctor

    public WalletTransactionDetailUpdated(Guid businessId, Guid userId, string description, WalletTransactionType transactionTypeId)
    {
        BusinessId = businessId;
        UserId = userId;
        Description = description;
        TransactionTypeId = transactionTypeId;
    }

    #endregion
}