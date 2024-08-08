using Contracts.Common.Models.Enums;

namespace Contracts.Events.MatchMakingEvents;

public record MatchCancelEvent
{
    public required string MatchId { get; set; }
    public MatchCancelEnum Reason { get; set; }
}
