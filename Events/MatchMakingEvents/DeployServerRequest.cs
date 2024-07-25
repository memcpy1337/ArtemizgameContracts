using Contracts.Common.Models.Enums;

namespace Contracts.Events.MatchMakingEvents;

public record DeployServerRequest
{
    public required string MatchId { get; set; }
    public required List<string> UsersIp { get; set; }
    public GameTypeEnum Regime { get; set; }
}
