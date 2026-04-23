
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant289ActorType
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
    public static class UserEventPayloadVariant289ActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant289ActorType value)
        {
            return value switch
            {
                UserEventPayloadVariant289ActorType.Admin => "admin",
                UserEventPayloadVariant289ActorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant289ActorType? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserEventPayloadVariant289ActorType.Admin,
                "user" => UserEventPayloadVariant289ActorType.User,
                _ => null,
            };
        }
    }
}