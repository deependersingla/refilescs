//Converted by Deepender

using System.Collections.Generic;
using System.IO;
using Com.Tinkerpop.Rexster.Gremlin.Converter;
using Com.Tinkerpop.Rexster.Protocol;
using Javax.Script;
using Sharpen;

/// <summary>
/// Represents a response to a script request for use in a console where each results is serialized to a
/// string value in an array of strings.
/// </summary>
/// <remarks>
/// Represents a response to a script request for use in a console where each results is serialized to a
/// string value in an array of strings.
/// </remarks>
/// <author>Stephen Mallette (http://stephen.genoprime.com)</author>
public class ConsoleScriptResponseMessage : RexProMessage
{
	public string[] ConsoleLines;

	public byte[] Bindings;

	public virtual IList<string> ConsoleLinesAsList()
	{
		IList<string> list = new AList<string>();
		foreach (string line in ConsoleLines)
		{
			list.AddItem(line);
		}
		return list;
	}

	public virtual IList<string> BindingsAsList()
	{
		IList<string> bindings = new AList<string>();
		ByteBuffer bb = ByteBuffer.Wrap(this.Bindings);
		while (bb.HasRemaining())
		{
			int segmentLength = bb.GetInt();
			byte[] segmentBytes = new byte[segmentLength];
			bb.Get(segmentBytes);
			bindings.AddItem(Sharpen.Runtime.GetStringForBytes(segmentBytes));
		}
		return bindings;
	}

	/// <exception cref="System.IO.IOException"></exception>
	public static byte[] ConvertBindingsToByteArray(Bindings bindings)
	{
		ByteArrayOutputStream baos = new ByteArrayOutputStream();
		foreach (string key in bindings.Keys)
		{
			object val = bindings.Get(key);
			baos.Write(BitWorks.ConvertStringsToByteArray(key + "=" + (val == null ? "null" : 
				val.ToString())));
		}
		return baos.ToByteArray();
	}

	/// <exception cref="System.Exception"></exception>
	public static IList<string> ConvertResultToConsoleLines(object result)
	{
		ConsoleResultConverter converter = new ConsoleResultConverter(new StringWriter());
		return converter.Convert(result);
	}

	public override int EstimateMessageSize()
	{
		return BASE_MESSAGE_SIZE + (Bindings == null ? 0 : Bindings.Length) + EstimateConsoleLineSize
			();
	}

	private int EstimateConsoleLineSize()
	{
		int size = 0;
		if (ConsoleLines != null)
		{
			foreach (string cl in ConsoleLines)
			{
				size = size + cl.Length;
			}
		}
		return size;
	}
}
