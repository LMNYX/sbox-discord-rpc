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

		[ClientCmd( "drpc_tests_exception" )]
		public static void TestThrowException()
		{
			throw new DiscordRPC.Exceptions.Dispatch.PanicExclamationMark("This is a test!");
		}

	}
}
