using FlashScore.CORE.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FlashScore.API.Controllers
{
    public class CompetitionController : ApiController
    {
        IRepository _Repository;
        ILeague _LeagueService;
        public CompetitionController()
        {
            _Repository = new DAL.Repository();
            _LeagueService = new CORE.Services.LeagueService(_Repository);
        }

        // GET api/competition
        public IHttpActionResult Get()
        {
            var competitions = _Repository.GetCompetitions().Where((c) => c.Groups.Count == 1).ToList();            
            return Ok(competitions);
        }

        [Route("api/{competition}/{year}/round/{round_number}/matches")]
        [HttpGet]
        public IHttpActionResult GetCompetitionMatches(string competition, int year, int round_number) 
        {
            return Ok(_LeagueService.GetMatches(competition, year, round_number));
        }
        [Route("api/{competition}/{year}/matches")]
        [HttpGet]
        public IHttpActionResult GetCompetitionMatches(string competition, int year)
        {
            return Ok(_LeagueService.GetMatches(competition, year));
        }

    }
}
