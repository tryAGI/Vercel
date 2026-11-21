
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The pin scope: `zone` (a geo zone) or `global`.
    /// </summary>
    public enum CreateAiGatewayVirtualModelConfigRequestInferenceRegionProvidersScope
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
    public static class CreateAiGatewayVirtualModelConfigRequestInferenceRegionProvidersScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAiGatewayVirtualModelConfigRequestInferenceRegionProvidersScope value)
        {
            return value switch
            {
                CreateAiGatewayVirtualModelConfigRequestInferenceRegionProvidersScope.Global => "global",
                CreateAiGatewayVirtualModelConfigRequestInferenceRegionProvidersScope.Zone => "zone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAiGatewayVirtualModelConfigRequestInferenceRegionProvidersScope? ToEnum(string value)
        {
            return value switch
            {
                "global" => CreateAiGatewayVirtualModelConfigRequestInferenceRegionProvidersScope.Global,
                "zone" => CreateAiGatewayVirtualModelConfigRequestInferenceRegionProvidersScope.Zone,
                _ => null,
            };
        }
    }
}