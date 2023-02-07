using Microsoft.AspNetCore.SignalR;

namespace KomunYslugi
{
    public class ChatHub : Hub
    {
        public async Task Send(string message, string userName, string recipient_id, string sender_id)
        {
            await Clients.All.SendAsync("Receive", message, userName, recipient_id, sender_id);
        }
    }
}
