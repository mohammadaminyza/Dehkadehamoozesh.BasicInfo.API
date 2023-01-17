using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Common.ValueObjects;

namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.Entities
{
    public class TicketAnswer : Entity
    {
        #region Properties

        public BusinessId UserId { get; set; }
        public BusinessId TicketId { get; set; }
        public Description Text { get; set; }

        public Ticket Ticket { get; set; }

        #endregion

        #region Ctor

        private TicketAnswer()
        {

        }

        public TicketAnswer(BusinessId businessId, BusinessId userId, BusinessId ticketId, Description text)
        {
            UserId = userId;
            TicketId = ticketId;
            Text = text;
        }

        #endregion
    }
}