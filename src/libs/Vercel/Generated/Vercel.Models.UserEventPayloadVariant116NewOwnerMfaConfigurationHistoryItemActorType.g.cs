
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Type of actor
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemActorType
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
    public static class UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemActorType value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemActorType.Admin => "admin",
                UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemActorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemActorType? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemActorType.Admin,
                "user" => UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemActorType.User,
                _ => null,
            };
        }
    }
}