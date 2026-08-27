
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateStorageStoresBlobResponseStoreProjectsMetadataItemDeploymentsActionEnvironment
    {
        /// <summary>
        ///
        /// </summary>
        Development,
        /// <summary>
        ///
        /// </summary>
        Preview,
        /// <summary>
        ///
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateStorageStoresBlobResponseStoreProjectsMetadataItemDeploymentsActionEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStorageStoresBlobResponseStoreProjectsMetadataItemDeploymentsActionEnvironment value)
        {
            return value switch
            {
                CreateStorageStoresBlobResponseStoreProjectsMetadataItemDeploymentsActionEnvironment.Development => "development",
                CreateStorageStoresBlobResponseStoreProjectsMetadataItemDeploymentsActionEnvironment.Preview => "preview",
                CreateStorageStoresBlobResponseStoreProjectsMetadataItemDeploymentsActionEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStorageStoresBlobResponseStoreProjectsMetadataItemDeploymentsActionEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateStorageStoresBlobResponseStoreProjectsMetadataItemDeploymentsActionEnvironment.Development,
                "preview" => CreateStorageStoresBlobResponseStoreProjectsMetadataItemDeploymentsActionEnvironment.Preview,
                "production" => CreateStorageStoresBlobResponseStoreProjectsMetadataItemDeploymentsActionEnvironment.Production,
                _ => null,
            };
        }
    }
}