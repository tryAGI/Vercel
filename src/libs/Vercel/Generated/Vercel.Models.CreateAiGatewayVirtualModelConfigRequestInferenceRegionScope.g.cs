
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The pin scope: `zone` (a geo zone) or `global`.
    /// </summary>
    public enum CreateAiGatewayVirtualModelConfigRequestInferenceRegionScope
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
    public static class CreateAiGatewayVirtualModelConfigRequestInferenceRegionScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAiGatewayVirtualModelConfigRequestInferenceRegionScope value)
        {
            return value switch
            {
                CreateAiGatewayVirtualModelConfigRequestInferenceRegionScope.Global => "global",
                CreateAiGatewayVirtualModelConfigRequestInferenceRegionScope.Zone => "zone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAiGatewayVirtualModelConfigRequestInferenceRegionScope? ToEnum(string value)
        {
            return value switch
            {
                "global" => CreateAiGatewayVirtualModelConfigRequestInferenceRegionScope.Global,
                "zone" => CreateAiGatewayVirtualModelConfigRequestInferenceRegionScope.Zone,
                _ => null,
            };
        }
    }
}