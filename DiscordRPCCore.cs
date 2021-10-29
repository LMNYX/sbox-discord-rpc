using Sandbox;

namespace DiscordRPC
{
	/// <summary>
	/// Methods and fields that are mostly for internal use.
	/// </summary>
	public static class Utility
	{
		/// <summary>
		/// According to the <see href="https://discord.com/developers/docs/topics/rpc#rpc-server-ports">Discord RPC documentation</see> port range is [6463..6472].
		/// </summary>
		public readonly static short[] PossiblePorts = { 6463, 6464, 6465, 6466, 6467, 6468, 6469, 6470, 6471, 6472 };

		/// <summary>
		/// Refer to <see href="https://discord.com/developers/docs/topics/rpc#rpc-rpc-versions">Discord RPC documentation</see> in order to know which verison is present.
		/// </summary>
		public readonly static short Version = 1;
		
		/// <summary>
		/// Generates a random UUID string for Discord RPC payloads.
		/// </summary>
		/// <returns>Random UUID string</returns>
		public static string GetNonce()
		{
			return System.Guid.NewGuid().ToString( "B" )[1..^1];
		}
	}

	public class Core
	{
		/// <summary>
		/// Discord RPC command enum, used in creating payload (<see cref="DiscordRPC.Core.Payload"/>)
		/// <para>Reference: <see href="https://discord.com/developers/docs/topics/rpc#commands-and-events-rpc-commands"/></para>
		/// </summary>
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

		/// <summary>
		/// <para>Reference: <see href="https://discord.com/developers/docs/topics/rpc#commands-and-events-rpc-events"/></para>
		/// </summary>
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

		/// <summary>
		/// Structure of command sent to the Discord RPC in order to perform action. <br/>
		/// Field nonce must be unique randomly generated string. Recommended to use <see cref="DiscordRPC.Utility.GetNonce"/>.
		/// <para>Reference: <see href="https://discord.com/developers/docs/topics/rpc#payloads"/></para>
		/// </summary>
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
