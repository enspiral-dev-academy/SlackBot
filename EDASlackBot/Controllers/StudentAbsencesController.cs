using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EDASlackBot.Models;

namespace EDASlackBot.Controllers
{
    public class StudentAbsencesController : ApiController
    {
        // GET: api/StudentAbsences

        // POST: api/StudentAbsences
        public IHttpActionResult Post(SlackMessage value)
        {
            if (value.Text.Contains("is away".ToLowerInvariant()))
            {
                return Ok(new {text = "Have you added this absence to the Trello board?"});
            }
            return Ok();
        }

        // PUT: api/StudentAbsences/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/StudentAbsences/5
        public void Delete(int id)
        {
        }
    }
}
