using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorMatchImpl
{
    interface IMatch
    {
        void AddTeam(TeamType team, string teamName);

        void AddScore(TeamType team, Score score);

        int CalculateScore(TeamType team);
    }
}
