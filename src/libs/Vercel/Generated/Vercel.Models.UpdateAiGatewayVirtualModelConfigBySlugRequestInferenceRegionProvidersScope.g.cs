
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The pin scope: `zone` (a geo zone) or `global`.
    /// </summary>
    public enum UpdateAiGatewayVirtualModelConfigBySlugRequestInferenceRegionProvidersScope
    {
        /// <summary>
        /// `zone` (a geo zone) or `global`.
        /// </summary>
        Global,
        /// <summary>
        /// `zone` (a geo zone) or `global`.
        /// </summary>
        Zone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAiGatewayVirtualModelConfigBySlugRequestInferenceRegionProvidersScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAiGatewayVirtualModelConfigBySlugRequestInferenceRegionProvidersScope value)
        {
            return value switch
            {
                UpdateAiGatewayVirtualModelConfigBySlugRequestInferenceRegionProvidersScope.Global => "global",
                UpdateAiGatewayVirtualModelConfigBySlugRequestInferenceRegionProvidersScope.Zone => "zone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAiGatewayVirtualModelConfigBySlugRequestInferenceRegionProvidersScope? ToEnum(string value)
        {
            return value switch
            {
                "global" => UpdateAiGatewayVirtualModelConfigBySlugRequestInferenceRegionProvidersScope.Global,
                "zone" => UpdateAiGatewayVirtualModelConfigBySlugRequestInferenceRegionProvidersScope.Zone,
                _ => null,
            };
        }
    }
}