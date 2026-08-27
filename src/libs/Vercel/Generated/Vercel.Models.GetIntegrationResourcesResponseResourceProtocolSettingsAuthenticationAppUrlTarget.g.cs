
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetIntegrationResourcesResponseResourceProtocolSettingsAuthenticationAppUrlTarget
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
    public static class GetIntegrationResourcesResponseResourceProtocolSettingsAuthenticationAppUrlTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetIntegrationResourcesResponseResourceProtocolSettingsAuthenticationAppUrlTarget value)
        {
            return value switch
            {
                GetIntegrationResourcesResponseResourceProtocolSettingsAuthenticationAppUrlTarget.Development => "development",
                GetIntegrationResourcesResponseResourceProtocolSettingsAuthenticationAppUrlTarget.Preview => "preview",
                GetIntegrationResourcesResponseResourceProtocolSettingsAuthenticationAppUrlTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetIntegrationResourcesResponseResourceProtocolSettingsAuthenticationAppUrlTarget? ToEnum(string value)
        {
            return value switch
            {
                "development" => GetIntegrationResourcesResponseResourceProtocolSettingsAuthenticationAppUrlTarget.Development,
                "preview" => GetIntegrationResourcesResponseResourceProtocolSettingsAuthenticationAppUrlTarget.Preview,
                "production" => GetIntegrationResourcesResponseResourceProtocolSettingsAuthenticationAppUrlTarget.Production,
                _ => null,
            };
        }
    }
}