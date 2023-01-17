using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Common;
using System.ComponentModel;

namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.Tickets.Enums
{
    public enum TicketState
    {
        [Description(ResourceKeys.WaitForAnswer)]
        WaitForAnswer = 1,

        [Description(ResourceKeys.Answered)]
        Answered = 2,

        [Description(ResourceKeys.Closed)]
        Closed = 3
    }
}