using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorMatchImpl
{
    public class HurlingMatch : IHurlingMatch
    {
        public string[] TeamNames { get; set; }

        public List<Score> ScoresInMatch { get; set; }

        public HurlingMatch()
        {
            ScoresInMatch = new List<Score>();
            TeamNames = new string[2];
        }

        public void AddScore(TeamType team, Score score)
        {
            if (score != null)
            {
                score.Team = team;
                ScoresInMatch.Add(score);
            }
        }

        public void AddTeam(TeamType team, string teamName)
        {
            if (!string.IsNullOrWhiteSpace(teamName))
            {
                TeamNames[(int)team] = teamName;
            }
            else
            { 
                TeamNames[(int)team] = string.Empty;
            }
        }

        public int CalculateScore(TeamType team)
        {
            var teamScores = from scores in ScoresInMatch
                             where scores.Team == team
                             select scores;

            int scoreTotal = 0;
            foreach (var score in teamScores)
            {
                switch (score.TypeOfScore)
                {
                    case ScoreType.Point:
                        {
                            if (score.ScoreAmount > 0)
                            {
                                scoreTotal += 1;
                            }
                        }
                        
                        break;

                    case ScoreType.Goal:
                        {
                            if (score.ScoreAmount > 0)
                            {
                                scoreTotal += 3;
                            }
                        }
                        break;

                    default:
                        break;
                }
            }

            return scoreTotal;
        }

        public void AddGoal(TeamType team)
        {
            AddScore(team, new Score { Team = team, Time = DateTime.Now, ScoreAmount = 1, TypeOfScore = ScoreType.Goal });
        }

        public void AddPoint(TeamType team)
        {
            AddScore(team, new Score { Team = team, Time = DateTime.Now, ScoreAmount = 1, TypeOfScore = ScoreType.Point });
        }
    }
}
