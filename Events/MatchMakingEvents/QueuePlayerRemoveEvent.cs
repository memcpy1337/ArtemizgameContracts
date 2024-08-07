﻿using Contracts.Common.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Events.MatchMakingEvents;

public record QueuePlayerRemoveEvent
{
    public required string UserId { get; set; }
    public QueuePlayerRemoveEnum Reason { get; set; }
}
