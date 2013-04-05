//Converted by Deepender

using Sharpen;

/// <summary>Flags for the various messages.</summary>
/// <remarks>Flags for the various messages.</remarks>
/// <author>Stephen Mallette (http://stephen.genoprime.com)</author>
public class MessageFlag
{
	public const byte SCRIPT_RESPONSE_COMPLETE_MESSAGE = 0;

	public const byte ERROR_MESSAGE_VALIDATION = 0;

	public const byte ERROR_INVALID_SESSION = 1;

	public const byte ERROR_SCRIPT_FAILURE = 2;

	public const byte ERROR_AUTHENTICATION_FAILURE = 3;

	public const byte SCRIPT_REQUEST_IN_SESSION = 0;

	public const byte SCRIPT_REQUEST_NO_SESSION = 1;

	public const byte SESSION_REQUEST_NEW_SESSION = 0;

	public const byte SESSION_REQUEST_KILL_SESSION = 1;

	public const byte SESSION_RESPONSE_NO_FLAG = 0;
}
