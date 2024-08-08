using Contracts.Common.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Events.ServerEvents;

public record ServerBadDownEvent
{
    public required string ServerId { get; set; }
    public required string MatchId { get; set; }
    public ServerDownStatusEnum Status { get; set; }
}
