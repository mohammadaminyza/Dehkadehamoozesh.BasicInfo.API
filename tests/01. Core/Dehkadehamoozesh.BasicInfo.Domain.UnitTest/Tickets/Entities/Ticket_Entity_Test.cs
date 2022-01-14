using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Tickets.Entities;
using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Tickets.Enums;
using Moq;

namespace Dehkadehamoozesh.BasicInfo.Domain.UnitTest.Tickets.Entities;

public class Ticket_Entity_Test
{
    public static IEnumerable<object[]> GetTicket()
    {
        yield return new object[] { new Mock<Ticket>() };
    }
}
