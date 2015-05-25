using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace EDASlackBot.Models
{
    public class SlackMessage
    {
        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }
        [JsonProperty(PropertyName = "team_id")]
        public string TeamId { get; set; }
        [JsonProperty(PropertyName = "channel_id")]
        public string ChannelId { get; set; }
        [JsonProperty(PropertyName = "channel_name")]
        public string ChannelName { get; set; }
        [JsonProperty(PropertyName = "user_id")]
        public string UserId { get; set; }
        [JsonProperty(PropertyName = "user_name")]
        public string UserName { get; set; }
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
        [JsonProperty(PropertyName = "trigger_word")]
        public string TriggerWord { get; set; }
    }

    
}