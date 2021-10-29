using Sandbox;

namespace DiscordRPC
{
	public static class Tests
	{

		[ServerCmd( "drpc_tests_nonce" )]
		public static void TestsNonce()
		{
			Log.Info( DiscordRPC.Utility.GetNonce() );
		}

	}
}
