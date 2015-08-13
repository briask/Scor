using ScorMatchImpl;
using System;
using System.Linq;
using Xunit;

namespace HurlingMatchTests
{
    public class GameFactoryTests
    {
        [Fact]
        public void CreateGame_GivenHurlingType_CreatesHurlingMatch()
        {
            var game = GameFactory.CreateGame(GameType.Hurling);

            Assert.IsType<HurlingMatch>(game);
        }
    }
}
