namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.Events;

public class WalletTransactionDetailRemoved : IDomainEvent
{
    #region Properties

    public Guid BusinessId { get; set; }

    #endregion

    #region Ctor

    public WalletTransactionDetailRemoved(Guid businessId)
    {
        BusinessId = businessId;
    }

    #endregion
}