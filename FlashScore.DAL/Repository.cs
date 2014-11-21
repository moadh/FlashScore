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
    public class Repository :DbContext , IRepository 
    {

        public Repository() : base("FlashScoreContext"){}

        public IQueryable<CORE.Entity.Group> GetGroups()
        {
            return Groups;
        }

        public IQueryable<CORE.Entity.Competition> GetCompetitions()
        {
            return Competitions;
        }

        public IQueryable<CORE.Entity.Team> GetTeams()
        {
            return Teams;
        }
        public IQueryable<CORE.Entity.Round> GetRounds()
        {
            return Rounds;
        }
        public IQueryable<CORE.Entity.Match> GetMatchs()
        {
            return Matchs;
        }

        public IQueryable<CORE.Entity.MatchEvent> GetMatchEvents()
        {
            return MatchEvents;
        }


        public DbSet<MatchEvent> MatchEvents { get; set; }

        public DbSet<Match> Matchs { get; set; }

        public DbSet<Round> Rounds { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Competition> Competitions { get; set; }

    }
}
