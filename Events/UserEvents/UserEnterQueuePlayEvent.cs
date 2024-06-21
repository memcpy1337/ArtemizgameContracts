using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Events.UserEvents;
public record UserEnterQueuePlayEvent
{
    public required string UserId { get; set; }
    public int Elo { get; set; }
    public int PlayerType { get; set; }
    public int GameRegime { get; set; }

}
