using Contracts.Common.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Events.ServerEvents;

public record ServerGameEndEvent
{
    public required string ServerId { get; set; }
    public PlayerTypeEnum WonSide { get; set; }
}
