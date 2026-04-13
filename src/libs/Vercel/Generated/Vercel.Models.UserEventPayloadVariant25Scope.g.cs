
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant25Scope
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
    public static class UserEventPayloadVariant25ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant25Scope value)
        {
            return value switch
            {
                UserEventPayloadVariant25Scope.Email => "email",
                UserEventPayloadVariant25Scope.OfflineAccess => "offline_access",
                UserEventPayloadVariant25Scope.Openid => "openid",
                UserEventPayloadVariant25Scope.Profile => "profile",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant25Scope? ToEnum(string value)
        {
            return value switch
            {
                "email" => UserEventPayloadVariant25Scope.Email,
                "offline_access" => UserEventPayloadVariant25Scope.OfflineAccess,
                "openid" => UserEventPayloadVariant25Scope.Openid,
                "profile" => UserEventPayloadVariant25Scope.Profile,
                _ => null,
            };
        }
    }
}