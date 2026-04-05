
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemDeploymentsActionEnvironment
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
    public static class CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemDeploymentsActionEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemDeploymentsActionEnvironment value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemDeploymentsActionEnvironment.Development => "development",
                CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemDeploymentsActionEnvironment.Preview => "preview",
                CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemDeploymentsActionEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemDeploymentsActionEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemDeploymentsActionEnvironment.Development,
                "preview" => CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemDeploymentsActionEnvironment.Preview,
                "production" => CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemDeploymentsActionEnvironment.Production,
                _ => null,
            };
        }
    }
}