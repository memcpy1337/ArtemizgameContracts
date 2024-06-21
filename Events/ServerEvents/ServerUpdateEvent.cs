using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Events.ServerEvents;

public record ServerUpdateEvent
{
    public required string DeployId { get; set; }
    public required string MatchId { get; set; }
    public required string Message { get; set; }
    public bool IsReady { get; set; }
}
