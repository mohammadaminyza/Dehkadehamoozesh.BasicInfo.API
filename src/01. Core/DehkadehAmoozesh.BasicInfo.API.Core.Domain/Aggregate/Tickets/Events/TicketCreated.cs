using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Tickets.Enums;

namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Tickets.Events
{
    public class TicketCreated : IDomainEvent
    {
        #region Properties

        public Guid BusinessId { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public TicketState State { get; set; }

        #endregion

        #region Ctor

        public TicketCreated(Guid businessId, Guid userId, string title, string text, TicketState state)
        {
            BusinessId = businessId;
            UserId = userId;
            Title = title;
            Text = text;
            State = state;
        }

        #endregion
    }
}