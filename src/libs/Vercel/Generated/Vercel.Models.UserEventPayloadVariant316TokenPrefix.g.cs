
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The token prefix used when showing a safe checksum-style fingerprint.
    /// </summary>
    public enum UserEventPayloadVariant316TokenPrefix
    {
        /// <summary>
        /// 
        /// </summary>
        Vcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant316TokenPrefixExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant316TokenPrefix value)
        {
            return value switch
            {
                UserEventPayloadVariant316TokenPrefix.Vcp => "vcp_",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant316TokenPrefix? ToEnum(string value)
        {
            return value switch
            {
                "vcp_" => UserEventPayloadVariant316TokenPrefix.Vcp,
                _ => null,
            };
        }
    }
}