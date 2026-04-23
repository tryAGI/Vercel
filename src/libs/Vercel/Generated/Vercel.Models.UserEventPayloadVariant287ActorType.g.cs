
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant287ActorType
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
    public static class UserEventPayloadVariant287ActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant287ActorType value)
        {
            return value switch
            {
                UserEventPayloadVariant287ActorType.Admin => "admin",
                UserEventPayloadVariant287ActorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant287ActorType? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserEventPayloadVariant287ActorType.Admin,
                "user" => UserEventPayloadVariant287ActorType.User,
                _ => null,
            };
        }
    }
}