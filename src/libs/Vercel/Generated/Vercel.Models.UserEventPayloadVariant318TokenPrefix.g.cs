
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The token prefix used when showing a safe checksum-style fingerprint.
    /// </summary>
    public enum UserEventPayloadVariant318TokenPrefix
    {
        /// <summary>
        /// 
        /// </summary>
        Vcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant318TokenPrefixExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant318TokenPrefix value)
        {
            return value switch
            {
                UserEventPayloadVariant318TokenPrefix.Vcp => "vcp_",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant318TokenPrefix? ToEnum(string value)
        {
            return value switch
            {
                "vcp_" => UserEventPayloadVariant318TokenPrefix.Vcp,
                _ => null,
            };
        }
    }
}