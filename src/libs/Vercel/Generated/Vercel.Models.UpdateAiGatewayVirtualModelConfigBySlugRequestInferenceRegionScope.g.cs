
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The pin scope: `zone` (a geo zone) or `global`.
    /// </summary>
    public enum UpdateAiGatewayVirtualModelConfigBySlugRequestInferenceRegionScope
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
    public static class UpdateAiGatewayVirtualModelConfigBySlugRequestInferenceRegionScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAiGatewayVirtualModelConfigBySlugRequestInferenceRegionScope value)
        {
            return value switch
            {
                UpdateAiGatewayVirtualModelConfigBySlugRequestInferenceRegionScope.Global => "global",
                UpdateAiGatewayVirtualModelConfigBySlugRequestInferenceRegionScope.Zone => "zone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAiGatewayVirtualModelConfigBySlugRequestInferenceRegionScope? ToEnum(string value)
        {
            return value switch
            {
                "global" => UpdateAiGatewayVirtualModelConfigBySlugRequestInferenceRegionScope.Global,
                "zone" => UpdateAiGatewayVirtualModelConfigBySlugRequestInferenceRegionScope.Zone,
                _ => null,
            };
        }
    }
}