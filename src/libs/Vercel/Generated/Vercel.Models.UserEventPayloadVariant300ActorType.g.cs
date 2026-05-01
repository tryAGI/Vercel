
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant300ActorType
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
    public static class UserEventPayloadVariant300ActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant300ActorType value)
        {
            return value switch
            {
                UserEventPayloadVariant300ActorType.Admin => "admin",
                UserEventPayloadVariant300ActorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant300ActorType? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserEventPayloadVariant300ActorType.Admin,
                "user" => UserEventPayloadVariant300ActorType.User,
                _ => null,
            };
        }
    }
}