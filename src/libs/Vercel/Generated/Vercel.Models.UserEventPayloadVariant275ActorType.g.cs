
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant275ActorType
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
    public static class UserEventPayloadVariant275ActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant275ActorType value)
        {
            return value switch
            {
                UserEventPayloadVariant275ActorType.Admin => "admin",
                UserEventPayloadVariant275ActorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant275ActorType? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserEventPayloadVariant275ActorType.Admin,
                "user" => UserEventPayloadVariant275ActorType.User,
                _ => null,
            };
        }
    }
}