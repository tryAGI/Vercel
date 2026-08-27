
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrlTarget
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
    public static class GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrlTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrlTarget value)
        {
            return value switch
            {
                GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrlTarget.Development => "development",
                GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrlTarget.Preview => "preview",
                GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrlTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrlTarget? ToEnum(string value)
        {
            return value switch
            {
                "development" => GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrlTarget.Development,
                "preview" => GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrlTarget.Preview,
                "production" => GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrlTarget.Production,
                _ => null,
            };
        }
    }
}