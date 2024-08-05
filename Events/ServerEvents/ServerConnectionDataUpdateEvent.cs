using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Events.ServerEvents;

public record ServerConnectionDataUpdateEvent
{
    public required string MatchId { get; set; }
    public required string ServerId { get; set; }
    public required string Address { get; set; }
    public int Port { get; set; }
}
