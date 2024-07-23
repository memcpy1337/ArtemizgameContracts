using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Events.MatchMakingEvents;

public record MatchCancelEvent
{
    public required string MatchId { get; set; }
    public required string ReasonMsg { get; set; }
}
