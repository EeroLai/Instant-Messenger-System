using Microsoft.AspNetCore.SignalR;

namespace InstantMessengerApi.Hubs
{
    public class ChatHub : Hub
    {
        public Task SendMessage(string msg)
        {
            return Clients.All.SendAsync("ReceiveMsg", msg);
        }
        public async Task SendMessage2(string msg)
        {
            await Clients.All.SendAsync("ReceiveMsg2", msg + "SendMessage2");
        }
    }
}