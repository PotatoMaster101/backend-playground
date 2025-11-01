using System.Text;

namespace Protocols.PublishSubscribe.Requests;

/// <summary>
/// Represents a request to publish a message.
/// </summary>
/// <param name="Message">The message to publish.</param>
public record PublishRequest(string Message)
{
    /// <summary>
    /// Returns <see cref="Message"/> encoded as UTF-8.
    /// </summary>
    public byte[] Encode()
    {
        return Encoding.UTF8.GetBytes(Message);
    }
}
