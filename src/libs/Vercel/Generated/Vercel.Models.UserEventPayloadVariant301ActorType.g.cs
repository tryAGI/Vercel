
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant301ActorType
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
    public static class UserEventPayloadVariant301ActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant301ActorType value)
        {
            return value switch
            {
                UserEventPayloadVariant301ActorType.Admin => "admin",
                UserEventPayloadVariant301ActorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant301ActorType? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserEventPayloadVariant301ActorType.Admin,
                "user" => UserEventPayloadVariant301ActorType.User,
                _ => null,
            };
        }
    }
}