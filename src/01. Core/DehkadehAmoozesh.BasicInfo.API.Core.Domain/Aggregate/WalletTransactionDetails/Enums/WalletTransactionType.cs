using System.ComponentModel;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Common;

namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.WalletTransactionDetails.Enums;

public enum WalletTransactionType
{
    [Description(ResourceKeys.DepositIsDecreaseWallet)]
    Deposit = 1,

    [Description(ResourceKeys.ChargeIsIncreaseWallet)]
    Charge = 2
}