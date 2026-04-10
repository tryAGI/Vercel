
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant274ActorType
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
    public static class UserEventPayloadVariant274ActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant274ActorType value)
        {
            return value switch
            {
                UserEventPayloadVariant274ActorType.Admin => "admin",
                UserEventPayloadVariant274ActorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant274ActorType? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserEventPayloadVariant274ActorType.Admin,
                "user" => UserEventPayloadVariant274ActorType.User,
                _ => null,
            };
        }
    }
}