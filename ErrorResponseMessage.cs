//Converted by Deepender

using Sharpen;

/// <summary>Represents an Error message.</summary>
/// <remarks>Represents an Error message.</remarks>
/// <author>Stephen Mallette (http://stephen.genoprime.com)</author>
public class ErrorResponseMessage : RexProMessage
{
	public string ErrorMessage;

	public override int EstimateMessageSize()
	{
		return BASE_MESSAGE_SIZE + (ErrorMessage == null ? 0 : ErrorMessage.Length);
	}
}
