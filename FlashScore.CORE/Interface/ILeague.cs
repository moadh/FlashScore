using FlashScore.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashScore.CORE.Interface
{
    public interface ILeague
    {
        IList<Match> GetMatches(string competitionName, int year, int roundId);
        Competition GetMatches(string competitionName, int year);
    }
}
