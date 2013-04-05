//Converted by Deepender

using Com.Tinkerpop.Rexster.Protocol;
using Sharpen;

/// <summary>A basic RexProMessage containing the basic components of every message that Rexster can process.
/// 	</summary>
/// <remarks>A basic RexProMessage containing the basic components of every message that Rexster can process.
/// 	</remarks>
/// <author>Stephen Mallette (http://stephen.genoprime.com)</author>
public abstract class RexProMessage
{
	/// <summary>Constant that represents the size of a RexProMessage.</summary>
	/// <remarks>Constant that represents the size of a RexProMessage.</remarks>
	protected internal const int BASE_MESSAGE_SIZE = 36;

	/// <summary>The standard value for an empty session.</summary>
	/// <remarks>The standard value for an empty session.</remarks>
	public static readonly UUID EMPTY_SESSION = new UUID(0, 0);

	public static readonly byte[] EMPTY_SESSION_AS_BYTES = BitWorks.ConvertUUIDToByteArray
		(EMPTY_SESSION);

	public static readonly UUID EMPTY_REQUEST = new UUID(0, 0);

	public static readonly byte[] EMPTY_REQUEST_AS_BYTES = BitWorks.ConvertUUIDToByteArray
		(EMPTY_REQUEST);

	/// <summary>Denotes the version of RexPro that is being used.</summary>
	/// <remarks>Denotes the version of RexPro that is being used.</remarks>
	public byte Version = 0;

	/// <summary>A value used to denote different states in different messages.</summary>
	/// <remarks>
	/// A value used to denote different states in different messages.  See specific message implementations
	/// for how this field is used.
	/// </remarks>
	public byte Flag;

	/// <summary>Denotes the session on which the message is sent.</summary>
	/// <remarks>Denotes the session on which the message is sent. Reserved for 16 bytes and resolves to a UUID.
	/// 	</remarks>
	public byte[] Session;

	/// <summary>A value that uniquely identifies a request.</summary>
	/// <remarks>A value that uniquely identifies a request. Reserved for 16 bytes and resolves to a UUID.
	/// 	</remarks>
	public byte[] Request;

	public virtual bool HasSession()
	{
		return this.Session != null && !this.SessionAsUUID().Equals(EMPTY_SESSION);
	}

	public virtual UUID SessionAsUUID()
	{
		return BitWorks.ConvertByteArrayToUUID(this.Session);
	}

	public virtual void SetSessionAsUUID(UUID session)
	{
		this.Session = BitWorks.ConvertUUIDToByteArray(session);
	}

	public virtual UUID RequestAsUUID()
	{
		return BitWorks.ConvertByteArrayToUUID(this.Request);
	}

	public virtual void SetRequestAsUUID(UUID request)
	{
		this.Request = BitWorks.ConvertUUIDToByteArray(request);
	}

	/// <returns>the estimated size of the message in bytes.</returns>
	public abstract int EstimateMessageSize();
}
