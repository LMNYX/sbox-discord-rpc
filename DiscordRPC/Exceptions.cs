using System;

namespace DiscordRPC
{
	public class DiscordException
	{
		[Serializable]
		public class AllPortsAreUsed : Exception
		{
			public AllPortsAreUsed() { }
			public AllPortsAreUsed( string message ) : base( message ) { }
			public AllPortsAreUsed( string message, Exception innerException ) : base( message, innerException ) { }
		}

		public class Dispatch
		{
			[Serializable]
			public class RequestSigningFailed : Exception
			{
				public RequestSigningFailed() { }
				public RequestSigningFailed( string message ) : base( message ) { }
				public RequestSigningFailed( string message, Exception innerException ) : base( message, innerException ) { }
			}

			[Serializable]
			public class DiskSpaceLow : Exception
			{
				public DiskSpaceLow() { }
				public DiskSpaceLow( string message ) : base( message ) { }
				public DiskSpaceLow( string message, Exception innerException ) : base( message, innerException ) { }
			}

			[Serializable]
			public class DiskPermissionDenied : Exception
			{
				public DiskPermissionDenied() { }
				public DiskPermissionDenied( string message ) : base( message ) { }
				public DiskPermissionDenied( string message, Exception innerException ) : base( message, innerException ) { }
			}

			[Serializable]
			public class UninstallFailed : Exception
			{
				public UninstallFailed() { }
				public UninstallFailed( string message ) : base( message ) { }
				public UninstallFailed( string message, Exception innerException ) : base( message, innerException ) { }
			}

			[Serializable]
			public class InstallScriptFailed : Exception
			{
				public InstallScriptFailed() { }
				public InstallScriptFailed( string message ) : base( message ) { }
				public InstallScriptFailed( string message, Exception innerException ) : base( message, innerException ) { }
			}

			[Serializable]
			public class BuildNotFound : Exception
			{
				public BuildNotFound() { }
				public BuildNotFound( string message ) : base( message ) { }
				public BuildNotFound( string message, Exception innerException ) : base( message, innerException ) { }
			}

			[Serializable]
			public class PanicExclamationMark : Exception
			{
				public PanicExclamationMark() { }
				public PanicExclamationMark( string message ) : base( message ) { }
				public PanicExclamationMark( string message, Exception innerException ) : base( message, innerException ) { }
			}

			[Serializable]
			public class TooManyAPIRetries : Exception
			{
				public TooManyAPIRetries() { }
				public TooManyAPIRetries( string message ) : base( message ) { }
				public TooManyAPIRetries( string message, Exception innerException ) : base( message, innerException ) { }
			}

			[Serializable]
			public class FailedToSetRegistryKey : Exception
			{
				public FailedToSetRegistryKey() { }
				public FailedToSetRegistryKey( string message ) : base( message ) { }
				public FailedToSetRegistryKey( string message, Exception innerException ) : base( message, innerException ) { }
			}

			[Serializable]
			public class FailedToPatchFile : Exception
			{
				public FailedToPatchFile() { }
				public FailedToPatchFile( string message ) : base( message ) { }
				public FailedToPatchFile( string message, Exception innerException ) : base( message, innerException ) { }
			}

			[Serializable]
			public class NoManifests : Exception
			{
				public NoManifests() { }
				public NoManifests( string message ) : base( message ) { }
				public NoManifests( string message, Exception innerException ) : base( message, innerException ) { }
			}

			[Serializable]
			public class APIError : Exception
			{
				public APIError() { }
				public APIError( string message ) : base( message ) { }
				public APIError( string message, Exception innerException ) : base( message, innerException ) { }
			}

			[Serializable]
			public class BadResponse : Exception
			{
				public BadResponse() { }
				public BadResponse( string message ) : base( message ) { }
				public BadResponse( string message, Exception innerException ) : base( message, innerException ) { }
			}

			[Serializable]
			public class NotEntitled : Exception
			{
				public NotEntitled() { }
				public NotEntitled( string message ) : base( message ) { }
				public NotEntitled( string message, Exception innerException ) : base( message, innerException ) { }
			}

			[Serializable]
			public class TwoClientsPatching : Exception
			{
				public TwoClientsPatching() { }
				public TwoClientsPatching( string message ) : base( message ) { }
				public TwoClientsPatching( string message, Exception innerException ) : base( message, innerException ) { }
			}

			[Serializable]
			public class Unknown : Exception
			{
				public Unknown() { }
				public Unknown( string message ) : base( message ) { }
				public Unknown( string message, Exception innerException ) : base( message, innerException ) { }
			}
		}
	}
}
