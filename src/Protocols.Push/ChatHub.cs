using Microsoft.AspNetCore.SignalR;

namespace Protocols.Push;

/// <summary>
/// Hub for handling chat messages.
/// </summary>
public class ChatHub : Hub
{
    /// <summary>
    /// Sends a chat message to all clients.
    /// </summary>
    public Task SendMessage(string user, string message)
    {
        return Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}
