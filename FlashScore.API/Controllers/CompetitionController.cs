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
        // GET api/competition
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/competition/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/competition
        public void Post([FromBody]string value)
        {
        }

        // PUT api/competition/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/competition/5
        public void Delete(int id)
        {
        }
    }
}
