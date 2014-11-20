using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashScore.CORE.Entity
{
  public  class Match
    {
        public int Id
        {
            get;
            set;
        }

        public string TeamA
        {
            get;
            set;
        }
        public string TeamB
        {
            get;
            set;
        }
        public DateTime Date
        {
            get;
            set;
        }
        public IList<Score> Scores
        {
            get;
            set;
        }
        public IList<MatchEvent> MatchEvents
        {
            get;
            set;
        }
    }
}
