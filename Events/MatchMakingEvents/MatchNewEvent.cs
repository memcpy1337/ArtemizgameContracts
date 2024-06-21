using Contracts.Common.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Events.MatchMakingEvents;

public record MatchNewEvent
{
    public required string MatchId { get; set; }
    public GameTypeEnum GameType { get; set; }
}
