
#nullable enable

namespace Vercel
{
    /// <summary>
    /// optional; only present when a refresh token was issued (offline_access).
    /// </summary>
    public enum UserEventPayloadVariant309RefreshTokenPrefix
    {
        /// <summary>
        /// 
        /// </summary>
        Vcr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant309RefreshTokenPrefixExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant309RefreshTokenPrefix value)
        {
            return value switch
            {
                UserEventPayloadVariant309RefreshTokenPrefix.Vcr => "vcr_",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant309RefreshTokenPrefix? ToEnum(string value)
        {
            return value switch
            {
                "vcr_" => UserEventPayloadVariant309RefreshTokenPrefix.Vcr,
                _ => null,
            };
        }
    }
}