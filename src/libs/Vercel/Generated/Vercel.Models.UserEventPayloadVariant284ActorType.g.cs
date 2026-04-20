
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant284ActorType
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
    public static class UserEventPayloadVariant284ActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant284ActorType value)
        {
            return value switch
            {
                UserEventPayloadVariant284ActorType.Admin => "admin",
                UserEventPayloadVariant284ActorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant284ActorType? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserEventPayloadVariant284ActorType.Admin,
                "user" => UserEventPayloadVariant284ActorType.User,
                _ => null,
            };
        }
    }
}