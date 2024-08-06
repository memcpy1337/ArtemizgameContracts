using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Common.Models.Enums;

public enum MatchCancelEnum
{
    NoPlayerInMatch,
    SomePlayersNotConnected,
    ServerCantBeInit,
    InternalError
}
