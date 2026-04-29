
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant33NextScope
    {
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        OfflineAccess,
        /// <summary>
        /// 
        /// </summary>
        Openid,
        /// <summary>
        /// 
        /// </summary>
        Profile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant33NextScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant33NextScope value)
        {
            return value switch
            {
                UserEventPayloadVariant33NextScope.Email => "email",
                UserEventPayloadVariant33NextScope.OfflineAccess => "offline_access",
                UserEventPayloadVariant33NextScope.Openid => "openid",
                UserEventPayloadVariant33NextScope.Profile => "profile",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant33NextScope? ToEnum(string value)
        {
            return value switch
            {
                "email" => UserEventPayloadVariant33NextScope.Email,
                "offline_access" => UserEventPayloadVariant33NextScope.OfflineAccess,
                "openid" => UserEventPayloadVariant33NextScope.Openid,
                "profile" => UserEventPayloadVariant33NextScope.Profile,
                _ => null,
            };
        }
    }
}