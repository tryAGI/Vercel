
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Optional explicit format marker. The destination is identified by the presence of `service`, so `type` is no longer required.
    /// </summary>
    public enum AutoSDKShared82154186cc88506cDestinationType
    {
        /// <summary>
        ///
        /// </summary>
        Service,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared82154186cc88506cDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared82154186cc88506cDestinationType value)
        {
            return value switch
            {
                AutoSDKShared82154186cc88506cDestinationType.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared82154186cc88506cDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "service" => AutoSDKShared82154186cc88506cDestinationType.Service,
                _ => null,
            };
        }
    }
}