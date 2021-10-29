using System;

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
			return Guid.NewGuid().ToString( "B" )[1..^1];
		}
	}
}
