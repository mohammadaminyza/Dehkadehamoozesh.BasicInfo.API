using M.YZ.Basement.Core.Domain.Events;

namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.WalletTransactionDetails.Events;

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