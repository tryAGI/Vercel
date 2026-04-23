
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant290ActorType
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
    public static class UserEventPayloadVariant290ActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant290ActorType value)
        {
            return value switch
            {
                UserEventPayloadVariant290ActorType.Admin => "admin",
                UserEventPayloadVariant290ActorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant290ActorType? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserEventPayloadVariant290ActorType.Admin,
                "user" => UserEventPayloadVariant290ActorType.User,
                _ => null,
            };
        }
    }
}