
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Type of actor
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemActorType
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
    public static class UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemActorType value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemActorType.Admin => "admin",
                UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemActorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemActorType? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemActorType.Admin,
                "user" => UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemActorType.User,
                _ => null,
            };
        }
    }
}