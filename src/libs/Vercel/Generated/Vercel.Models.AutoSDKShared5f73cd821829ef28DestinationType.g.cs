
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Optional explicit format marker. The destination is identified by the presence of `service`, so `type` is no longer required.
    /// </summary>
    public enum AutoSDKShared5f73cd821829ef28DestinationType
    {
        /// <summary>
        ///
        /// </summary>
        Service,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared5f73cd821829ef28DestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5f73cd821829ef28DestinationType value)
        {
            return value switch
            {
                AutoSDKShared5f73cd821829ef28DestinationType.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5f73cd821829ef28DestinationType? ToEnum(string value)
        {
            return value switch
            {
                "service" => AutoSDKShared5f73cd821829ef28DestinationType.Service,
                _ => null,
            };
        }
    }
}