using Microsoft.AspNetCore.SignalR;

namespace InstantMessengerApi.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string msg)
        {
            await Clients.All.SendAsync("ReceiveMsg", msg);
        }
    }
}