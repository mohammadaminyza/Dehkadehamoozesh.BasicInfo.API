namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.Events
{
    public class TicketRemoved : IDomainEvent
    {

        #region Properties

        public Guid BusinessId { get; set; }

        #endregion

        #region Ctor

        public TicketRemoved(Guid businessId)
        {
            BusinessId = businessId;
        }

        #endregion
    }
}