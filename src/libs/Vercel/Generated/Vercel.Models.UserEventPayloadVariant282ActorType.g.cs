
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant282ActorType
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
    public static class UserEventPayloadVariant282ActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant282ActorType value)
        {
            return value switch
            {
                UserEventPayloadVariant282ActorType.Admin => "admin",
                UserEventPayloadVariant282ActorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant282ActorType? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserEventPayloadVariant282ActorType.Admin,
                "user" => UserEventPayloadVariant282ActorType.User,
                _ => null,
            };
        }
    }
}