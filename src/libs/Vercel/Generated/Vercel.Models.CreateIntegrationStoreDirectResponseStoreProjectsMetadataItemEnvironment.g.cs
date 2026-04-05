
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemEnvironment
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
    public static class CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemEnvironment value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemEnvironment.Development => "development",
                CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemEnvironment.Preview => "preview",
                CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemEnvironment.Development,
                "preview" => CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemEnvironment.Preview,
                "production" => CreateIntegrationStoreDirectResponseStoreProjectsMetadataItemEnvironment.Production,
                _ => null,
            };
        }
    }
}