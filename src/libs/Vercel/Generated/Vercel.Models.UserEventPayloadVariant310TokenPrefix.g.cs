
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The token prefix used when showing a safe checksum-style fingerprint.
    /// </summary>
    public enum UserEventPayloadVariant310TokenPrefix
    {
        /// <summary>
        /// 
        /// </summary>
        Vcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant310TokenPrefixExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant310TokenPrefix value)
        {
            return value switch
            {
                UserEventPayloadVariant310TokenPrefix.Vcp => "vcp_",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant310TokenPrefix? ToEnum(string value)
        {
            return value switch
            {
                "vcp_" => UserEventPayloadVariant310TokenPrefix.Vcp,
                _ => null,
            };
        }
    }
}