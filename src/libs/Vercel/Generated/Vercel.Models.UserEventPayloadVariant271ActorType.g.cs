
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant271ActorType
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
    public static class UserEventPayloadVariant271ActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant271ActorType value)
        {
            return value switch
            {
                UserEventPayloadVariant271ActorType.Admin => "admin",
                UserEventPayloadVariant271ActorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant271ActorType? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserEventPayloadVariant271ActorType.Admin,
                "user" => UserEventPayloadVariant271ActorType.User,
                _ => null,
            };
        }
    }
}