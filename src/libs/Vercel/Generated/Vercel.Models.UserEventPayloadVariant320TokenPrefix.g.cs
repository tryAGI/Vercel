
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The token prefix used when showing a safe checksum-style fingerprint.
    /// </summary>
    public enum UserEventPayloadVariant320TokenPrefix
    {
        /// <summary>
        /// 
        /// </summary>
        Vcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant320TokenPrefixExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant320TokenPrefix value)
        {
            return value switch
            {
                UserEventPayloadVariant320TokenPrefix.Vcp => "vcp_",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant320TokenPrefix? ToEnum(string value)
        {
            return value switch
            {
                "vcp_" => UserEventPayloadVariant320TokenPrefix.Vcp,
                _ => null,
            };
        }
    }
}