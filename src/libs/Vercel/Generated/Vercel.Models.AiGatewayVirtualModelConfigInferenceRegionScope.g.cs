
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Pin scope: `specific` (one provider region), `zone` (geo zone), or `global`.
    /// </summary>
    public enum AiGatewayVirtualModelConfigInferenceRegionScope
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
    public static class AiGatewayVirtualModelConfigInferenceRegionScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiGatewayVirtualModelConfigInferenceRegionScope value)
        {
            return value switch
            {
                AiGatewayVirtualModelConfigInferenceRegionScope.Global => "global",
                AiGatewayVirtualModelConfigInferenceRegionScope.Specific => "specific",
                AiGatewayVirtualModelConfigInferenceRegionScope.Zone => "zone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiGatewayVirtualModelConfigInferenceRegionScope? ToEnum(string value)
        {
            return value switch
            {
                "global" => AiGatewayVirtualModelConfigInferenceRegionScope.Global,
                "specific" => AiGatewayVirtualModelConfigInferenceRegionScope.Specific,
                "zone" => AiGatewayVirtualModelConfigInferenceRegionScope.Zone,
                _ => null,
            };
        }
    }
}