
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The pin scope: `zone` (a geo zone) or `global`.
    /// </summary>
    public enum UpdateAiGatewayVirtualModelConfigRequestInferenceRegionScope
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
    public static class UpdateAiGatewayVirtualModelConfigRequestInferenceRegionScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAiGatewayVirtualModelConfigRequestInferenceRegionScope value)
        {
            return value switch
            {
                UpdateAiGatewayVirtualModelConfigRequestInferenceRegionScope.Global => "global",
                UpdateAiGatewayVirtualModelConfigRequestInferenceRegionScope.Zone => "zone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAiGatewayVirtualModelConfigRequestInferenceRegionScope? ToEnum(string value)
        {
            return value switch
            {
                "global" => UpdateAiGatewayVirtualModelConfigRequestInferenceRegionScope.Global,
                "zone" => UpdateAiGatewayVirtualModelConfigRequestInferenceRegionScope.Zone,
                _ => null,
            };
        }
    }
}