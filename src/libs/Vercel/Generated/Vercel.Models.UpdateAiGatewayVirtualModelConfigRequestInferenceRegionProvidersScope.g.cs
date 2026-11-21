
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The pin scope: `zone` (a geo zone) or `global`.
    /// </summary>
    public enum UpdateAiGatewayVirtualModelConfigRequestInferenceRegionProvidersScope
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
    public static class UpdateAiGatewayVirtualModelConfigRequestInferenceRegionProvidersScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAiGatewayVirtualModelConfigRequestInferenceRegionProvidersScope value)
        {
            return value switch
            {
                UpdateAiGatewayVirtualModelConfigRequestInferenceRegionProvidersScope.Global => "global",
                UpdateAiGatewayVirtualModelConfigRequestInferenceRegionProvidersScope.Zone => "zone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAiGatewayVirtualModelConfigRequestInferenceRegionProvidersScope? ToEnum(string value)
        {
            return value switch
            {
                "global" => UpdateAiGatewayVirtualModelConfigRequestInferenceRegionProvidersScope.Global,
                "zone" => UpdateAiGatewayVirtualModelConfigRequestInferenceRegionProvidersScope.Zone,
                _ => null,
            };
        }
    }
}