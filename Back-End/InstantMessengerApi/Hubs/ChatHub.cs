using Microsoft.AspNetCore.SignalR;

namespace InstantMessengerApi.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string msg)
        {
            await Clients.All.SendAsync("ReceiveMsg", user, msg);
        }
    }
}