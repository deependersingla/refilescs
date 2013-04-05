//Converted by Deepender

using System.Collections.Generic;
using Sharpen;

/// <author>Stephen Mallette (http://stephen.genoprime.com)</author>
public class MessageUtil
{
	public static ErrorResponseMessage CreateErrorResponse(byte[] request, byte[] session
		, byte flag, string errorMessage)
	{
		ErrorResponseMessage msg = new ErrorResponseMessage();
		msg.Request = request;
		msg.Session = session;
		msg.ErrorMessage = errorMessage;
		msg.Flag = flag;
		return msg;
	}

	public static SessionResponseMessage CreateNewSession(byte[] request, IList<string
		> languages)
	{
		UUID sessionKey = UUID.RandomUUID();
		SessionResponseMessage responseMessage = new SessionResponseMessage();
		responseMessage.SetSessionAsUUID(sessionKey);
		responseMessage.Request = request;
		responseMessage.Flag = MessageFlag.SESSION_RESPONSE_NO_FLAG;
		responseMessage.Languages = new string[languages.Count];
		Sharpen.Collections.ToArray(languages, responseMessage.Languages);
		return responseMessage;
	}

	public static SessionResponseMessage CreateEmptySession(byte[] request)
	{
		SessionResponseMessage responseMessage = new SessionResponseMessage();
		responseMessage.SetSessionAsUUID(RexProMessage.EMPTY_SESSION);
		responseMessage.Request = request;
		responseMessage.Languages = new string[0];
		responseMessage.Flag = MessageFlag.SESSION_RESPONSE_NO_FLAG;
		return responseMessage;
	}
}
