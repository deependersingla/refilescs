//Converted by Deepender

using Sharpen;

/// <summary>
/// Represents a response to a session request with a newly defined session and available ScriptEngine
/// languages or a closed session confirmation.
/// </summary>
/// <remarks>
/// Represents a response to a session request with a newly defined session and available ScriptEngine
/// languages or a closed session confirmation.
/// </remarks>
/// <author>Stephen Mallette (http://stephen.genoprime.com)</author>
public class SessionResponseMessage : RexProMessage
{
	public string[] Languages;

	public override int EstimateMessageSize()
	{
		return BASE_MESSAGE_SIZE + EstimateLanguagesSize();
	}

	private int EstimateLanguagesSize()
	{
		int size = 0;
		if (Languages != null)
		{
			foreach (string l in Languages)
			{
				size = size + l.Length;
			}
		}
		return size;
	}
}
