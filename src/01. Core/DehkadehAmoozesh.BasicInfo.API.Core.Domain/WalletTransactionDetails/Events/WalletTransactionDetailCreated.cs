using DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.Enums;

namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.Events;

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