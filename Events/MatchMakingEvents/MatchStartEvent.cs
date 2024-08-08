using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Events.MatchMakingEvents;

[MessageUrn("match-status-update")]
public record MatchStartEvent
{
    public required string MatchId { get; set; }
}
