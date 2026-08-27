
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetStorageStoresByIdResponseStoreProjectsMetadataItemDeploymentsActionEnvironment
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
    public static class GetStorageStoresByIdResponseStoreProjectsMetadataItemDeploymentsActionEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStorageStoresByIdResponseStoreProjectsMetadataItemDeploymentsActionEnvironment value)
        {
            return value switch
            {
                GetStorageStoresByIdResponseStoreProjectsMetadataItemDeploymentsActionEnvironment.Development => "development",
                GetStorageStoresByIdResponseStoreProjectsMetadataItemDeploymentsActionEnvironment.Preview => "preview",
                GetStorageStoresByIdResponseStoreProjectsMetadataItemDeploymentsActionEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStorageStoresByIdResponseStoreProjectsMetadataItemDeploymentsActionEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "development" => GetStorageStoresByIdResponseStoreProjectsMetadataItemDeploymentsActionEnvironment.Development,
                "preview" => GetStorageStoresByIdResponseStoreProjectsMetadataItemDeploymentsActionEnvironment.Preview,
                "production" => GetStorageStoresByIdResponseStoreProjectsMetadataItemDeploymentsActionEnvironment.Production,
                _ => null,
            };
        }
    }
}