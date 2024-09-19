using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Events.UserEvents;

public record UserInfoRequest
{
    public required string UserId { get; init; }
}
