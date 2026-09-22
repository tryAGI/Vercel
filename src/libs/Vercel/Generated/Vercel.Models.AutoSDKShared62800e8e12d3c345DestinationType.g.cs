
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Optional explicit format marker. The destination is identified by the presence of `service`, so `type` is no longer required.
    /// </summary>
    public enum AutoSDKShared62800e8e12d3c345DestinationType
    {
        /// <summary>
        ///
        /// </summary>
        Service,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared62800e8e12d3c345DestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared62800e8e12d3c345DestinationType value)
        {
            return value switch
            {
                AutoSDKShared62800e8e12d3c345DestinationType.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared62800e8e12d3c345DestinationType? ToEnum(string value)
        {
            return value switch
            {
                "service" => AutoSDKShared62800e8e12d3c345DestinationType.Service,
                _ => null,
            };
        }
    }
}