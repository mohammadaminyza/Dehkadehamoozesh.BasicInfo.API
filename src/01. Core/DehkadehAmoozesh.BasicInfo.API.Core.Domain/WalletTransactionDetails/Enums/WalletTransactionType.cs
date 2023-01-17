using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Common;
using System.ComponentModel;

namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.Enums;

public enum WalletTransactionType
{
    [Description(ResourceKeys.DepositIsDecreaseWallet)]
    Deposit = 1,

    [Description(ResourceKeys.ChargeIsIncreaseWallet)]
    Charge = 2
}