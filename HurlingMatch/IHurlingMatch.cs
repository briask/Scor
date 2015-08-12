using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorMatchImpl
{
    interface IHurlingMatch : IMatch
    {
        void AddGoal(TeamType team);

        void AddPoint(TeamType team);
    }
}
