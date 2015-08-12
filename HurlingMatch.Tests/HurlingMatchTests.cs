using ScorMatchImpl;
using System;
using Xunit;

namespace HurlingMatchTests
{
    public class HurlingMatchTests
    {
        [Fact]
        public void AddTeam_HasHomeTeamName_AddsHomeTeam()
        {
            var match = new HurlingMatch();

            match.AddTeam(TeamType.Home, "HomeTeam");

            Assert.Equal("HomeTeam", match.TeamNames[(int)TeamType.Home]);
        }

        [Fact]
        public void AddScore_ValidScore_ScoreAdded()
        {
            var match = new HurlingMatch();
            var theScore = new Score();

            match.AddScore(TeamType.Home, theScore);

            Assert.Equal(1, match.ScoresInMatch.Count);
        }

        [Fact]
        public void AddScore_ValidScore_ScoreAddedCorrectly()
        {
            var match = new HurlingMatch();
            var theScore = new Score();

            theScore.Team = TeamType.Home;
            theScore.Time = new DateTime(2015, 8, 8, 12, 12, 12);

            theScore.ScoreAmount = 1;

            match.AddScore(TeamType.Home, theScore);

            Assert.Equal(1, match.ScoresInMatch.Count);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 1)]
        [InlineData(1, 0, 3)]
        [InlineData(1, 1, 4)]
        public void CalculateScore_ScoreCalculatedCorrectly(int goals, int points, int score)
        {
            var match = new HurlingMatch();
            match.AddScore(TeamType.Home, new Score { Team = TeamType.Home, ScoreAmount = goals, TypeOfScore = ScoreType.Goal, Time = DateTime.Now });
            match.AddScore(TeamType.Home, new Score { Team = TeamType.Home, ScoreAmount = points, TypeOfScore = ScoreType.Point, Time = DateTime.Now });

            var scoreTotal = match.CalculateScore(TeamType.Home);

            Assert.Equal(score, scoreTotal);
        }

        [Fact]
        public void AddGoal_GoalAdded()
        {
            var match = new HurlingMatch();

            match.AddGoal(TeamType.Home);

            Assert.Equal(1, match.ScoresInMatch.Count);
            Assert.Equal(ScoreType.Goal, match.ScoresInMatch[0].TypeOfScore);
        }

        [Fact]
        public void Addpoint_PointAdded()
        {
            var match = new HurlingMatch();

            match.AddPoint(TeamType.Home);

            Assert.Equal(1, match.ScoresInMatch.Count);
            Assert.Equal(ScoreType.Point, match.ScoresInMatch[0].TypeOfScore);
        }
    }
}
