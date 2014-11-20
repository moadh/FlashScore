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
        public IQueryable<CORE.Entity.Group> GetGroups()
        {
            return Groups;
        }

        public IQueryable<CORE.Entity.Competition> GetCompetitions()
        {
            return Competitions;
        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Competition> Competitions { get; set; }

    }
}
