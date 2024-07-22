using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Events.ServerEvents;

public record ServerDeployEvent
{
    public required string MatchId { get; set; }
    public bool IsSuccess { get; set; }
    public string? Message { get; set; }
}
