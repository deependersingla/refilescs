//Converted by Deepender

using Sharpen;

/// <author>Stephen Mallette (http://stephen.genoprime.com)</author>
public sealed class MessageTokens
{
	public static readonly string ERROR_INVALID_TAG = "The message has an invalid flag.";

	public static readonly string ERROR_SESSION_NOT_SPECIFIED = "The message does not specify a session.";

	public static readonly string ERROR_SESSION_INVALID = "The session on the request does not exist or has otherwise expired.";

	public static readonly string ERROR_IN_SCRIPT_PROCESSING = "An error occurred while processing the script for language [%s]. All transactions across all graphs in the session have been concluded with failure: %s";

	public static readonly string ERROR_UNEXPECTED_MESSAGE_TYPE = "Message did not match an expected type.";
}
