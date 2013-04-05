//Converted by Deepender

using Com.Tinkerpop.Rexster.Protocol;
using Sharpen;

/// <summary>Represents a request to process a script.</summary>
/// <remarks>Represents a request to process a script.</remarks>
/// <author>Stephen Mallette (http://stephen.genoprime.com)</author>
public class ScriptRequestMessage : RexProMessage
{
	public string LanguageName;

	public string Script;

	public byte[] Bindings;

	/// <exception cref="System.IO.IOException"></exception>
	/// <exception cref="System.TypeLoadException"></exception>
	public virtual RexsterBindings GetBindings()
	{
		ByteBuffer buffer = ByteBuffer.Wrap(this.Bindings);
		byte[] theRest = new byte[buffer.Remaining()];
		buffer.Get(theRest);
		return BitWorks.ConvertByteArrayToRexsterBindings(theRest);
	}

	public override int EstimateMessageSize()
	{
		return BASE_MESSAGE_SIZE + (LanguageName == null ? 0 : LanguageName.Length) + (Script
			 == null ? 0 : Script.Length) + (Bindings == null ? 0 : Bindings.Length);
	}
}
