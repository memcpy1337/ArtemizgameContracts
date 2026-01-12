using Contracts.Common.Models.Enums;
using MassTransit;

namespace Contracts.Events.MatchMakingEvents;

[MessageUrn("match-status-update")]
public record MatchCancelEvent
{
    public required string MatchId { get; set; }
    public MatchCancelEnum Reason { get; set; }
    public required string UserId { get; set; }
}
