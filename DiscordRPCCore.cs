using Sandbox;

namespace DiscordRPC
{
	public static class Utility
	{
		// https://discord.com/developers/docs/topics/rpc#rpc-server-ports
		public static short[] PossiblePorts = { 6463, 6464, 6465, 6466, 6467, 6468, 6469, 6470, 6471, 6472 };
		public static string GetNonce()
		{
			return System.Guid.NewGuid().ToString( "B" )[1..^1];
		}
	}
	public class Core
	{
		public enum Command
		{
			DISPATCH,
			AUTHORIZE,
			AUTHENTICATE,
			GET_GUILD,
			GET_GUILDS,
			GET_CHANNEL,
			SUBSCRIBE,
			UNSUBSCRIBE,
			SET_USER_VOICE_SETTINGS,
			SELECT_VOICE_CHANNEL,
			GET_SELECTED_VOICE_CHANNEL,
			GET_VOICE_SETTINGS,
			SET_VOICE_SETTINGS,
			SET_CERTIFIED_DEVICES,
			SET_ACTIVITY,
			SEND_ACTIVITY_JOIN_INVITE,
			CLOSE_ACTIVITY_REQUEST
		}
		public enum RPCEvent
		{
			NONE = -1,
			READY,
			ERROR,
			GUILD_STATUS,
			GUILD_CREATE,
			CHANNEL_CREATE,
			VOICE_CHANNEL_SELECT,
			VOICE_STATE_CREATE,
			VOICE_STATE_UPDATE,
			VOICE_STATE_DELETE,
			VOICE_CONNECTION_STATUS,
			SPEAKING_START,
			SPEAKING_STOP,
			MESSAGE_CREATE,
			MESSAGE_UPDATE,
			MESSAGE_DELETE,
			NOTIFICATION_CREATE,
			ACTIVITY_JOIN,
			ACTIVITY_SPECTATE,
			ACTIVITY_JOIN_REQUEST
		}
		public struct Payload
		{
			Command cmd;
			string nonce;
			RPCEvent evt;
			object data;
			object args;
		}
	}
}
