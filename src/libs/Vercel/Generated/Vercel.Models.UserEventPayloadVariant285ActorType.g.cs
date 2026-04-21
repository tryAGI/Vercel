
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant285ActorType
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
    public static class UserEventPayloadVariant285ActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant285ActorType value)
        {
            return value switch
            {
                UserEventPayloadVariant285ActorType.Admin => "admin",
                UserEventPayloadVariant285ActorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant285ActorType? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserEventPayloadVariant285ActorType.Admin,
                "user" => UserEventPayloadVariant285ActorType.User,
                _ => null,
            };
        }
    }
}