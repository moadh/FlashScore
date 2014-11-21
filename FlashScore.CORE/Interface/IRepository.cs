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
        IQueryable<Competition> GetTeams();
        IQueryable<Competition> GetRounds();
        IQueryable<Competition> GetMatchs();
        IQueryable<Competition> GetMatchEvents();
    }
}
