using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashScore.CORE.Entity
{
   public enum MatchEventType
    {        
       Entry = 1,
       Substitution = 2,
       YellowCard = 3,
       RedCard = 4,
       Foul = 5,
       FreeKick = 6,
       CornerKick = 7,
       PenaltyKick = 8,
       Goal = 9
    }
}
