using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRSampleServer
{
    public class PostItem
    {
        string id;
        string body;
        string title;

        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        [Newtonsoft.Json.JsonProperty("postImage")]
        public string PostImage { get; set; }

        [Newtonsoft.Json.JsonProperty("userId")]
        public string UserId { get; set; }

        [Newtonsoft.Json.JsonProperty("groupID")]
        public string GroupID { get; set; }

        [Newtonsoft.Json.JsonProperty("reactionCount")]
        public int reactionCount { get; set; } = 0;

        [Newtonsoft.Json.JsonProperty(PropertyName = "body")]
        public string Body
        {
            get { return body; }
            set { body = value; }
        }

        [Newtonsoft.Json.JsonProperty(PropertyName = "title")]
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        [Microsoft.WindowsAzure.MobileServices.Version]
        public string Version { get; set; }
    }
}