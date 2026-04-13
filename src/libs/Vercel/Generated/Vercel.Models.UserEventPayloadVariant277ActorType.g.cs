
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant277ActorType
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
    public static class UserEventPayloadVariant277ActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant277ActorType value)
        {
            return value switch
            {
                UserEventPayloadVariant277ActorType.Admin => "admin",
                UserEventPayloadVariant277ActorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant277ActorType? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserEventPayloadVariant277ActorType.Admin,
                "user" => UserEventPayloadVariant277ActorType.User,
                _ => null,
            };
        }
    }
}