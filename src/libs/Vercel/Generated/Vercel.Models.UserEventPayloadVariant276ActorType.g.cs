
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant276ActorType
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
    public static class UserEventPayloadVariant276ActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant276ActorType value)
        {
            return value switch
            {
                UserEventPayloadVariant276ActorType.Admin => "admin",
                UserEventPayloadVariant276ActorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant276ActorType? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserEventPayloadVariant276ActorType.Admin,
                "user" => UserEventPayloadVariant276ActorType.User,
                _ => null,
            };
        }
    }
}