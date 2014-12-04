using FlashScore.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashScore.DAL.EF
{
    internal class DbContext : System.Data.Entity.DbContext
    {
        public DbContext() : base("FlashScoreContext")
        {            
            this.Configuration.LazyLoadingEnabled = false; 
            this.Configuration.ProxyCreationEnabled = false; 
        }
        
        public DbSet<MatchEvent> MatchEvents { get; set; }

        public DbSet<Match> Matchs { get; set; }

        public DbSet<Round> Rounds { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Competition> Competitions { get; set; }
    }
}
