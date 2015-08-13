using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorMatchImpl
{
    public static class GameFactory
    {
        static public IMatch CreateGame(GameType game)
        {
            IMatch gameToReturn = null;
            switch (game)
            {
                case GameType.Hurling:
                    gameToReturn = new HurlingMatch();
                    break;

                case GameType.Football:
                    break;

                case GameType.Soccer:
                    break;

                default:
                    break;
            }

            return gameToReturn;
        }
    }
}
