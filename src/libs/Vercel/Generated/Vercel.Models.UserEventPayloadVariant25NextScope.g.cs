
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant25NextScope
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
    public static class UserEventPayloadVariant25NextScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant25NextScope value)
        {
            return value switch
            {
                UserEventPayloadVariant25NextScope.Email => "email",
                UserEventPayloadVariant25NextScope.OfflineAccess => "offline_access",
                UserEventPayloadVariant25NextScope.Openid => "openid",
                UserEventPayloadVariant25NextScope.Profile => "profile",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant25NextScope? ToEnum(string value)
        {
            return value switch
            {
                "email" => UserEventPayloadVariant25NextScope.Email,
                "offline_access" => UserEventPayloadVariant25NextScope.OfflineAccess,
                "openid" => UserEventPayloadVariant25NextScope.Openid,
                "profile" => UserEventPayloadVariant25NextScope.Profile,
                _ => null,
            };
        }
    }
}