using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EDASlackBot.Models;
using Microsoft.Azure;

namespace EDASlackBot.Controllers
{
    public class StudentAbsencesController : ApiController
    {
        // POST: api/StudentAbsences
        public IHttpActionResult Post(SlackMessage value)
        {
            var studentAwayWords = CloudConfigurationManager.GetSetting("AwayPhrases").Split(','); 
            if (studentAwayWords.Any(word => value.Text.Contains(word)))
            {
                return Ok(new {text = string.Format("Have you added this absence to the Trello board? {0}", CloudConfigurationManager.GetSetting("TrelloLink")) });
            }

            return Ok();
        }
    }
}
