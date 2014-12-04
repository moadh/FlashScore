using FlashScore.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashScore.CORE.Interface
{
    public interface IRepository
    {
        IQueryable<Group> GetGroups();
        IQueryable<Competition> GetCompetitions();
        IQueryable<Team> GetTeams();
        IQueryable<Round> GetRounds();
        IQueryable<Match> GetMatchs();
        IQueryable<MatchEvent> GetMatchEvents();
        IList<Match> GetMatchsByRound(string competitionName, int year, int roundNumber);
        Competition GetMatchsByCompetition(string competitionName, int year);
    }
}
