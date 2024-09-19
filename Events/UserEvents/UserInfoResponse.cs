using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Events.UserEvents;

public record UserInfoResponse
{
    public required string UserId { get; set; }
    public required string NickName { get; set; }
}
