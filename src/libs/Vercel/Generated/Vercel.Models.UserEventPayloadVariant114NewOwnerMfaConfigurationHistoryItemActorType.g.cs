
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Type of actor
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemActorType
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemActorType value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemActorType.Admin => "admin",
                UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemActorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemActorType? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemActorType.Admin,
                "user" => UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemActorType.User,
                _ => null,
            };
        }
    }
}