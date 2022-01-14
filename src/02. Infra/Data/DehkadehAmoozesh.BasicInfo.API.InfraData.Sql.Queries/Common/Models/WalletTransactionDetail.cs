namespace DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Queries.Common.Models
{
    public class WalletTransactionDetail
    {
        public long Id { get; set; }

        public Guid UserId { get; set; }
        public string Description { get; set; }
        public int TransactionTypeId { get; set; }

        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public int? ModifiedByUserId { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public Guid BusinessId { get; set; }
    }
}