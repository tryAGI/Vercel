
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant278ActorType
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
    public static class UserEventPayloadVariant278ActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant278ActorType value)
        {
            return value switch
            {
                UserEventPayloadVariant278ActorType.Admin => "admin",
                UserEventPayloadVariant278ActorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant278ActorType? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserEventPayloadVariant278ActorType.Admin,
                "user" => UserEventPayloadVariant278ActorType.User,
                _ => null,
            };
        }
    }
}