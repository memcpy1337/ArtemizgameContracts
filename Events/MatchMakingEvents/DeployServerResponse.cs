using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Events.MatchMakingEvents;

public record DeployServerResponse
{
    public required string MatchId { get; set; }
    public bool IsError { get; set; }
    public string? Message { get; set; }
}
