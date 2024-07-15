using Contracts.Common.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Common.Helpers;

public static class Helpers
{
    public static int GetTargetPlayersCountForGameType(GameTypeEnum gameTypeEnum, PlayerTypeEnum playerType)
    {
        switch(gameTypeEnum)
        {
            case GameTypeEnum.Classic:
                if (playerType == PlayerTypeEnum.Crew)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            case GameTypeEnum.BotMonster:
                if (playerType == PlayerTypeEnum.Crew)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            case GameTypeEnum.OneByOne:
                if (playerType == PlayerTypeEnum.Crew)
                {
                    return 1;
                }
                else
                {
                    return 1;
                }
            case GameTypeEnum.OneVsBot:
                if (playerType == PlayerTypeEnum.Crew)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            default: return 0;
        }
    }
}
