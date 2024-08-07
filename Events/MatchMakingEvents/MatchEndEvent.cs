﻿using Contracts.Common.Models;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Events.MatchMakingEvents;

[MessageUrn("match-status-update")]
public record MatchEndEvent
{
    public required string MatchId { get; set; }
    public required List<MatchPlayerResult> Results { get; set; }
}
