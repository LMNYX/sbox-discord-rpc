using Sandbox;

namespace DiscordRPC
{
	public static class Tests
	{
		[ServerCmd( "drpc_tests_nonce" )]
		public static void TestsNonce()
		{
			Log.Info( Utility.GetNonce() );
		}

		[ClientCmd( "drpc_tests_exception" )]
		public static void TestThrowException()
		{
			throw new DiscordException.Dispatch.PanicExclamationMark( "This is a test!" );
		}

		[ClientCmd( "drpc_tests_connect" )]
		public static void TestConnect()
		{
			Core.Connect( "localhost:6463" );
		}

		[ClientCmd( "drpc_tests_disconnect" )]
		public static void TestDisconnect()
		{
			Core.Disconnect();
		}
	}
}
