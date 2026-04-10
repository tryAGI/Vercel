
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant26NextScope
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
    public static class UserEventPayloadVariant26NextScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant26NextScope value)
        {
            return value switch
            {
                UserEventPayloadVariant26NextScope.Email => "email",
                UserEventPayloadVariant26NextScope.OfflineAccess => "offline_access",
                UserEventPayloadVariant26NextScope.Openid => "openid",
                UserEventPayloadVariant26NextScope.Profile => "profile",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant26NextScope? ToEnum(string value)
        {
            return value switch
            {
                "email" => UserEventPayloadVariant26NextScope.Email,
                "offline_access" => UserEventPayloadVariant26NextScope.OfflineAccess,
                "openid" => UserEventPayloadVariant26NextScope.Openid,
                "profile" => UserEventPayloadVariant26NextScope.Profile,
                _ => null,
            };
        }
    }
}