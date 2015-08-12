using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorMatchImpl
{
    public class Score
    {
        public TeamType Team { get; set; }

        public DateTime Time { get; set; }
 
        public ScoreType TypeOfScore { get; set; }

        public int ScoreAmount { get; set; }
    }
}
