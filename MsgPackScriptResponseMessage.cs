//Converted by Deepender

using Com.Tinkerpop.Rexster.Gremlin.Converter;
using Sharpen;

/// <summary>Represents a response to a script request that formats results to MsgPack format.
/// 	</summary>
/// <remarks>Represents a response to a script request that formats results to MsgPack format.
/// 	</remarks>
/// <author>Stephen Mallette (http://stephen.genoprime.com)</author>
public class MsgPackScriptResponseMessage : RexProMessage
{
	private static readonly MsgPackResultConverter converter = new MsgPackResultConverter
		();

	public byte[] Results;

	public byte[] Bindings;

	/// <exception cref="System.Exception"></exception>
	public static byte[] ConvertResultToBytes(object result)
	{
		return converter.Convert(result);
	}

	public override int EstimateMessageSize()
	{
		return BASE_MESSAGE_SIZE + (Results == null ? 0 : Results.Length) + (Bindings == 
			null ? 0 : Bindings.Length);
	}
}
