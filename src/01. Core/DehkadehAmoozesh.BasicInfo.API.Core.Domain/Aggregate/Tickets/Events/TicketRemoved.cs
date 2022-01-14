using System;
using M.YZ.Basement.Core.Domain.Events;

namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Tickets.Events
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