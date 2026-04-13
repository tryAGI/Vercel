
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant27NextScope
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
    public static class UserEventPayloadVariant27NextScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant27NextScope value)
        {
            return value switch
            {
                UserEventPayloadVariant27NextScope.Email => "email",
                UserEventPayloadVariant27NextScope.OfflineAccess => "offline_access",
                UserEventPayloadVariant27NextScope.Openid => "openid",
                UserEventPayloadVariant27NextScope.Profile => "profile",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant27NextScope? ToEnum(string value)
        {
            return value switch
            {
                "email" => UserEventPayloadVariant27NextScope.Email,
                "offline_access" => UserEventPayloadVariant27NextScope.OfflineAccess,
                "openid" => UserEventPayloadVariant27NextScope.Openid,
                "profile" => UserEventPayloadVariant27NextScope.Profile,
                _ => null,
            };
        }
    }
}