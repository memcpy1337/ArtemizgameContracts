using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Events.ServerEvents;

[MessageUrn("user-connection-event")]
public class ServerPlayerDisconnectedEvent
{
    public required string ServerId { get; set; }
    public required string UserId { get; set; }
}
