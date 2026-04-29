
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant31Scope
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
    public static class UserEventPayloadVariant31ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant31Scope value)
        {
            return value switch
            {
                UserEventPayloadVariant31Scope.Email => "email",
                UserEventPayloadVariant31Scope.OfflineAccess => "offline_access",
                UserEventPayloadVariant31Scope.Openid => "openid",
                UserEventPayloadVariant31Scope.Profile => "profile",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant31Scope? ToEnum(string value)
        {
            return value switch
            {
                "email" => UserEventPayloadVariant31Scope.Email,
                "offline_access" => UserEventPayloadVariant31Scope.OfflineAccess,
                "openid" => UserEventPayloadVariant31Scope.Openid,
                "profile" => UserEventPayloadVariant31Scope.Profile,
                _ => null,
            };
        }
    }
}