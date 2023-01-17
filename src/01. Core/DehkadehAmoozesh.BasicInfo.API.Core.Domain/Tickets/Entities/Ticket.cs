using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.Enums;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.Events;
using M.YZ.Basement.Core.Domain.Toolkits.ValueObjects;
using Description = DehkadehAmoozesh.BasicInfo.API.Core.Domain.Common.ValueObjects.Description;

namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.Entities
{
    public class Ticket : AggregateRoot
    {
        #region Properties

        public BusinessId UserId { get; set; }
        public Title Title { get; set; }
        public Description Text { get; set; }
        public TicketState State { get; set; }

        public IReadOnlyCollection<TicketAnswer> TicketAnswers => _ticketAnswer.ToList();
        private readonly HashSet<TicketAnswer> _ticketAnswer = new();

        #endregion

        #region Ctor

        private Ticket()
        {

        }

        public Ticket(BusinessId businessId, BusinessId userId, Title title, Description text, TicketState state)
        {
            BusinessId = businessId;
            UserId = userId;
            Title = title;
            Text = text;
            State = state;

            AddEvent(new TicketCreated(BusinessId.Value, UserId.Value, Title.Value, Text.Value, State));
        }

        #endregion

        #region Method

        public void Delete()
        {
            AddEvent(new TicketRemoved(BusinessId.Value));
        }

        public void AddTicketAnswer(TicketAnswer ticketAnswer)
        {
            _ticketAnswer.Add(ticketAnswer);
        }

        #endregion
    }
}