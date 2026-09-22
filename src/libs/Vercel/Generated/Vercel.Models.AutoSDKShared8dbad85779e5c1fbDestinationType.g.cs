
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Optional explicit format marker. The destination is identified by the presence of `service`, so `type` is no longer required.
    /// </summary>
    public enum AutoSDKShared8dbad85779e5c1fbDestinationType
    {
        /// <summary>
        ///
        /// </summary>
        Service,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared8dbad85779e5c1fbDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8dbad85779e5c1fbDestinationType value)
        {
            return value switch
            {
                AutoSDKShared8dbad85779e5c1fbDestinationType.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8dbad85779e5c1fbDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "service" => AutoSDKShared8dbad85779e5c1fbDestinationType.Service,
                _ => null,
            };
        }
    }
}