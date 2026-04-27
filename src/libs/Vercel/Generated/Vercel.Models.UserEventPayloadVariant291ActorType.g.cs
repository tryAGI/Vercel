
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant291ActorType
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
    public static class UserEventPayloadVariant291ActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant291ActorType value)
        {
            return value switch
            {
                UserEventPayloadVariant291ActorType.Admin => "admin",
                UserEventPayloadVariant291ActorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant291ActorType? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserEventPayloadVariant291ActorType.Admin,
                "user" => UserEventPayloadVariant291ActorType.User,
                _ => null,
            };
        }
    }
}