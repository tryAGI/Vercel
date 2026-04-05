
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant23Scope
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
    public static class UserEventPayloadVariant23ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant23Scope value)
        {
            return value switch
            {
                UserEventPayloadVariant23Scope.Email => "email",
                UserEventPayloadVariant23Scope.OfflineAccess => "offline_access",
                UserEventPayloadVariant23Scope.Openid => "openid",
                UserEventPayloadVariant23Scope.Profile => "profile",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant23Scope? ToEnum(string value)
        {
            return value switch
            {
                "email" => UserEventPayloadVariant23Scope.Email,
                "offline_access" => UserEventPayloadVariant23Scope.OfflineAccess,
                "openid" => UserEventPayloadVariant23Scope.Openid,
                "profile" => UserEventPayloadVariant23Scope.Profile,
                _ => null,
            };
        }
    }
}