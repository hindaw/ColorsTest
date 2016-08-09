using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Colors.Controllers
{
    public class DataController : ApiController
    {
        /// <summary>
        /// This function returns a list of colors
        /// </summary>
        /// <returns>List</returns>
        public List<Colors> Get()
        {
            return DB.Colors.ToList();
        }

        /// <summary>
        /// This function totals votes by color code
        /// </summary>
        /// <param name="colorId"></param>
        /// <returns>int</returns>

        [HttpGet]
        public double GetVotes(int colorId)
        {
            return DB.VotesList.Where(x => x.Color == colorId).Sum(c => c.VotesNum);

        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

        
    }
}