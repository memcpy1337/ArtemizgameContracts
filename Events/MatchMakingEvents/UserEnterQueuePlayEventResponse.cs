using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Events.MatchMakingEvents;

public record UserEnterQueuePlayEventResponse
{
    public required string UserId { get; set; }
    public string Token { get; set; } = String.Empty;
}
