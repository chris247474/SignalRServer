using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRSampleServer
{
    public class ChatHub : Hub
    {
        public void SendToSecretFilesClient(PostItem message)
        {
            Clients.All.messageReceived(message);
        }
        public void SendComentsToClients(CommentItem message)
        {
            Clients.All.commentReceived(message);
        }
        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message);
        }
    }
}