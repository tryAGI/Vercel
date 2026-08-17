
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreProtocolSettingsAuthenticationAppUrlTarget
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
    public static class CreateIntegrationStoreDirectResponseStoreProtocolSettingsAuthenticationAppUrlTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreProtocolSettingsAuthenticationAppUrlTarget value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreProtocolSettingsAuthenticationAppUrlTarget.Development => "development",
                CreateIntegrationStoreDirectResponseStoreProtocolSettingsAuthenticationAppUrlTarget.Preview => "preview",
                CreateIntegrationStoreDirectResponseStoreProtocolSettingsAuthenticationAppUrlTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreProtocolSettingsAuthenticationAppUrlTarget? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateIntegrationStoreDirectResponseStoreProtocolSettingsAuthenticationAppUrlTarget.Development,
                "preview" => CreateIntegrationStoreDirectResponseStoreProtocolSettingsAuthenticationAppUrlTarget.Preview,
                "production" => CreateIntegrationStoreDirectResponseStoreProtocolSettingsAuthenticationAppUrlTarget.Production,
                _ => null,
            };
        }
    }
}