
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant24Scope
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
    public static class UserEventPayloadVariant24ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant24Scope value)
        {
            return value switch
            {
                UserEventPayloadVariant24Scope.Email => "email",
                UserEventPayloadVariant24Scope.OfflineAccess => "offline_access",
                UserEventPayloadVariant24Scope.Openid => "openid",
                UserEventPayloadVariant24Scope.Profile => "profile",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant24Scope? ToEnum(string value)
        {
            return value switch
            {
                "email" => UserEventPayloadVariant24Scope.Email,
                "offline_access" => UserEventPayloadVariant24Scope.OfflineAccess,
                "openid" => UserEventPayloadVariant24Scope.Openid,
                "profile" => UserEventPayloadVariant24Scope.Profile,
                _ => null,
            };
        }
    }
}