using Contracts.Common.Models.Enums;

namespace Contracts.Events.MatchMakingEvents;

public record MatchPlayerAddEvent
{
    public required string UserId { get; set; }
    public required string MatchId { get; set; }
    public MatchStatusEnum MatchStatus { get; set; }
}
