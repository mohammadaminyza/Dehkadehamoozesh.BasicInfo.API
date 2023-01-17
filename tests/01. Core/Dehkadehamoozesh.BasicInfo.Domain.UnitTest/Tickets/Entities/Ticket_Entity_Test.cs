using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.Entities;
using Moq;

namespace Dehkadehamoozesh.BasicInfo.Domain.UnitTest.Tickets.Entities;

public class Ticket_Entity_Test
{
    public static IEnumerable<object[]> GetTicket()
    {
        yield return new object[] { new Mock<Ticket>() };
    }
}
