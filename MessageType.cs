//Converted by Deepender

using Sharpen;

/// <summary>Values that represent standard message types for RexPro.</summary>
/// <remarks>Values that represent standard message types for RexPro.</remarks>
/// <author>Stephen Mallette (http://stephen.genoprime.com)</author>
public class MessageType
{
	/// <summary>Represents an Error message.</summary>
	/// <remarks>Represents an Error message.</remarks>
	public const byte ERROR = 0;

	/// <summary>Represents a request to open or close a session.</summary>
	/// <remarks>Represents a request to open or close a session.</remarks>
	public const byte SESSION_REQUEST = 1;

	/// <summary>
	/// Represents a response to a session request with a newly defined session and available ScriptEngine
	/// languages or a closed session confirmation..
	/// </summary>
	/// <remarks>
	/// Represents a response to a session request with a newly defined session and available ScriptEngine
	/// languages or a closed session confirmation..
	/// </remarks>
	public const byte SESSION_RESPONSE = 2;

	/// <summary>Represents a request to process a script.</summary>
	/// <remarks>Represents a request to process a script.</remarks>
	public const byte SCRIPT_REQUEST = 3;

	/// <summary>
	/// Represents a response to a script request for use in a console where each results is serialized to a
	/// string value in an array of strings.
	/// </summary>
	/// <remarks>
	/// Represents a response to a script request for use in a console where each results is serialized to a
	/// string value in an array of strings.
	/// </remarks>
	public const byte CONSOLE_SCRIPT_RESPONSE = 4;

	/// <summary>Represents a response to a script request that formats results to MsgPack format.
	/// 	</summary>
	/// <remarks>Represents a response to a script request that formats results to MsgPack format.
	/// 	</remarks>
	public const byte MSGPACK_SCRIPT_RESPONSE = 5;
}
