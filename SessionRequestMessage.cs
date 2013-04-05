//Converted by Deepender

using Sharpen;

/// <summary>Represents a request to open or close a session.</summary>
/// <remarks>Represents a request to open or close a session.</remarks>
/// <author>Stephen Mallette (http://stephen.genoprime.com)</author>
public class SessionRequestMessage : RexProMessage
{
	public const byte CHANNEL_NONE = 0;

	public const byte CHANNEL_CONSOLE = 1;

	public const byte CHANNEL_MSGPACK = 2;

	public const byte CHANNEL_GRAPHSON = 3;

	public byte Channel;

	public string Username;

	public string Password;

	public override int EstimateMessageSize()
	{
		return BASE_MESSAGE_SIZE + 1 + (Username == null ? 0 : Username.Length) + (Password
			 == null ? 0 : Password.Length);
	}
}
