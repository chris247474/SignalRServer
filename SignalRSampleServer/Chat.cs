using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRSampleServer
{
    public class ChatHub : Hub
    {
        //for communicating with certain clients or groups of clients
        //https://www.asp.net/signalr/overview/guide-to-the-api/mapping-users-to-connections

        public void SendToSecretFilesClient(PostItem message)
        {
            //get client's ID via
            //Context.ConnectionId

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