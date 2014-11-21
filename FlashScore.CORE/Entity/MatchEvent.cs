using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashScore.CORE.Entity
{
  public  class MatchEvent
    {
        public int Id
        {
            get;
            set;
        }

        public string Minute
        {
            get;
            set;
        }
        public MatchEventType MatchEventType
        {
            get;
            set;
        }
    }
}
