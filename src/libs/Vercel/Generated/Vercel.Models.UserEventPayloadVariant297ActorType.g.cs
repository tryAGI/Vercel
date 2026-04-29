
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant297ActorType
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
    public static class UserEventPayloadVariant297ActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant297ActorType value)
        {
            return value switch
            {
                UserEventPayloadVariant297ActorType.Admin => "admin",
                UserEventPayloadVariant297ActorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant297ActorType? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserEventPayloadVariant297ActorType.Admin,
                "user" => UserEventPayloadVariant297ActorType.User,
                _ => null,
            };
        }
    }
}