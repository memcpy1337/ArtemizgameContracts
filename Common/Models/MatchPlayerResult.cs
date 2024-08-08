using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Common.Models;

public class MatchPlayerResult
{
    public required string UserId { get; set; }
    public int EloRatingBefore { get; set; }
    public int EloRatingAfter { get; set; }
}
