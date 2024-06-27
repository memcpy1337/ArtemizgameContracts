using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Events.MatchMakingEvents;

public record MatchPlayerQueuedEvent
{
    public required string UserId { get; set; }
    public string Token { get; set; } = String.Empty;
    public bool IsSuccess { get; set; }
    public string Message { get; set; } = String.Empty;
}
