
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant272ActorType
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
    public static class UserEventPayloadVariant272ActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant272ActorType value)
        {
            return value switch
            {
                UserEventPayloadVariant272ActorType.Admin => "admin",
                UserEventPayloadVariant272ActorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant272ActorType? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserEventPayloadVariant272ActorType.Admin,
                "user" => UserEventPayloadVariant272ActorType.User,
                _ => null,
            };
        }
    }
}