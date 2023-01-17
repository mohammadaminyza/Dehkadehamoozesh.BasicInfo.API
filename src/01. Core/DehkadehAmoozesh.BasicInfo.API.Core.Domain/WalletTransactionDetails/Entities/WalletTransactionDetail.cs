using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Common.ValueObjects;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.Enums;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.Events;

namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.Entities;

public class WalletTransactionDetail : AggregateRoot
{
    #region Properties

    public BusinessId UserId { get; set; }
    public Description Description { get; set; }
    public WalletTransactionType TransactionTypeId { get; set; }

    #endregion

    #region Ctor

    public WalletTransactionDetail(BusinessId businessId, BusinessId userId, Description description, WalletTransactionType transactionTypeId)
    {
        BusinessId = businessId;
        UserId = userId;
        Description = description;
        TransactionTypeId = transactionTypeId;

        AddEvent(new WalletTransactionDetailCreated(BusinessId.Value, Description.Value, UserId.Value, transactionTypeId));
    }

    private WalletTransactionDetail()
    {

    }

    #endregion

    #region Methods

    public void Update(BusinessId businessId, BusinessId userId, Description description, int transactionTypeId)
    {
        BusinessId = businessId;
        UserId = userId;
        Description = description;
        TransactionTypeId = Enum.Parse<WalletTransactionType>(transactionTypeId.ToString());

        AddEvent(new WalletTransactionDetailUpdated(BusinessId.Value, UserId.Value, Description.Value, TransactionTypeId));
    }

    public void Delete()
    {
        AddEvent(new WalletTransactionDetailRemoved(BusinessId.Value));
    }

    #endregion
}