using FlashScore.CORE.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashScore.CORE.Services
{
    public class LeagueService : ILeague
    {
        private IRepository _Repository;

        public LeagueService(IRepository repository)
        {
            _Repository = repository;
        }
        public IList<Entity.Match> GetMatches(string competitionName, int year, int roundNumber)
        {
            //IList<Entity.Match> results;

            //var competition = _Repository.GetCompetitions().Where(c => c.Name == competitionName && c.Year == year).FirstOrDefault();
            //var round = _Repository.GetRounds().Where(r => r.Id == roundId);
            return _Repository.GetMatchsByRound( competitionName,  year ,roundNumber);
        }

        public Entity.Competition GetMatches(string competitionName, int year)
        {
            return _Repository.GetMatchsByCompetition(competitionName, year);
        }
    }
}
