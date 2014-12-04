using FlashScore.CORE.Entity;
using FlashScore.CORE.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashScore.DAL
{
    public class Repository : IRepository 
    {
        private EF.DbContext _Context;

        public Repository() 
        {
            _Context = new EF.DbContext();
        }

        public IQueryable<CORE.Entity.Group> GetGroups()
        {
            return _Context.Groups;
        }

        public IQueryable<CORE.Entity.Competition> GetCompetitions()
        {
            return _Context.Competitions.Include(c => c.Groups);
        }

        public IQueryable<CORE.Entity.Team> GetTeams()
        {
            return _Context.Teams;
        }
        public IQueryable<CORE.Entity.Round> GetRounds()
        {
            return _Context.Rounds;
        }
        public IQueryable<CORE.Entity.Match> GetMatchs()
        {
            return _Context.Matchs;
        }

        public IQueryable<CORE.Entity.MatchEvent> GetMatchEvents()
        {
            return _Context.MatchEvents;
        }

        public IList<Match> GetMatchsByRound(string competitionName, int year, int roundNumber)
        {
            //var compt = _Context.Competitions.Include(c => c.Rounds)
            //    .Where(c => c.Name == competitionName && c.Year == year)
            //    .FirstOrDefault();
            var round = _Context.Competitions.Include(c => c.Rounds)
                .Where(c => c.Name == competitionName && c.Year == year)
                .FirstOrDefault().Rounds.Where(r=> r.Number==roundNumber).FirstOrDefault();
            return _Context.Rounds.Include(r => r.Matchs).Where(r => r.Id == round.Id)
                .FirstOrDefault().Matchs;
        }


        public CORE.Entity.Competition GetMatchsByCompetition(string competitionName, int year)
        {
            var compt = _Context.Competitions.Include(c => c.Rounds)               
                 .Where(c => c.Name == competitionName && c.Year == year)                 
                 .FirstOrDefault();
            return compt;
        }
    }
}
