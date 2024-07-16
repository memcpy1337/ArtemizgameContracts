using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Events.MatchMakingEvents;

public record QueuePlayerAddEvent
{
    public required string UserId { get; set; }
    public required string TicketId { get; set; }
}
