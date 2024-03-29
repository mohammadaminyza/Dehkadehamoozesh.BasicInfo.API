﻿namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.WalletTransactionDetails.QueryModels.Outputs;

public class WalletTransactionDetailsDto
{
    public Guid BusinessId { get; set; }
    public Guid UserId { get; set; }
    public string Description { get; set; }
    public int TransactionTypeId { get; set; }

    public string CreatedByUser { get; set; }
    public DateTime? CreatedDateTime { get; set; }
    public string ModifiedByUser { get; set; }
    public DateTime? ModifiedDateTime { get; set; }
}