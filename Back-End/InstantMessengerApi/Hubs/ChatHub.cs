using Microsoft.AspNetCore.SignalR;

namespace InstantMessengerApi.Hubs
{
    public class ChatHub : Hub
    {
        public Task SendMessage(string msg)
        {
            return Clients.All.SendAsync("ReceiveMsg", msg);
        }
    }
}