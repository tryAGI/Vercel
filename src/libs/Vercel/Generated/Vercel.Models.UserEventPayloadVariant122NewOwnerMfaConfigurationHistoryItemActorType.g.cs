
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Type of actor
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemActorType
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
    public static class UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemActorType value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemActorType.Admin => "admin",
                UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemActorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemActorType? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemActorType.Admin,
                "user" => UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemActorType.User,
                _ => null,
            };
        }
    }
}