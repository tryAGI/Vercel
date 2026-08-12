
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Pin scope: `specific` (one provider region), `zone` (geo zone), or `global`.
    /// </summary>
    public enum AiGatewayVirtualModelConfigInferenceRegionProvidersScope
    {
        /// <summary>
        /// `specific` (one provider region), `zone` (geo zone), or `global`.
        /// </summary>
        Global,
        /// <summary>
        /// `specific` (one provider region), `zone` (geo zone), or `global`.
        /// </summary>
        Specific,
        /// <summary>
        /// `specific` (one provider region), `zone` (geo zone), or `global`.
        /// </summary>
        Zone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AiGatewayVirtualModelConfigInferenceRegionProvidersScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiGatewayVirtualModelConfigInferenceRegionProvidersScope value)
        {
            return value switch
            {
                AiGatewayVirtualModelConfigInferenceRegionProvidersScope.Global => "global",
                AiGatewayVirtualModelConfigInferenceRegionProvidersScope.Specific => "specific",
                AiGatewayVirtualModelConfigInferenceRegionProvidersScope.Zone => "zone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiGatewayVirtualModelConfigInferenceRegionProvidersScope? ToEnum(string value)
        {
            return value switch
            {
                "global" => AiGatewayVirtualModelConfigInferenceRegionProvidersScope.Global,
                "specific" => AiGatewayVirtualModelConfigInferenceRegionProvidersScope.Specific,
                "zone" => AiGatewayVirtualModelConfigInferenceRegionProvidersScope.Zone,
                _ => null,
            };
        }
    }
}