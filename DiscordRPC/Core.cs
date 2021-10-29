namespace DiscordRPC
{
	public class Core
	{
		/// <summary>
		/// Discord RPC command enum, used in creating payload (<see cref="Payload"/>)
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
		/// Field nonce must be unique randomly generated string. Recommended to use <see cref="Utility.GetNonce"/>.
		/// <para>Reference: <see href="https://discord.com/developers/docs/topics/rpc#payloads"/></para>
		/// </summary>
		public struct Payload
		{
			public Command cmd;
			public string nonce;
			public RPCEvent evt;
			public object data;
			public object args;
		}
	}
}
