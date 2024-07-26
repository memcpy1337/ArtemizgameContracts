﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Events.ServerEvents;

public class ServerPlayerDisconnectedEvent
{
    public required string ServerId { get; set; }
    public required string UserId { get; set; }
}
