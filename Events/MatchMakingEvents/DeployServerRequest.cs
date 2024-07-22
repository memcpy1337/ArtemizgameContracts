using Contracts.Common.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Events.MatchMakingEvents;

public record DeployServerRequest
{
    public required string MatchId { get; set; }
    public required List<string> UsersIp { get; set; }
    public GameTypeEnum Regime { get; set; }
}
