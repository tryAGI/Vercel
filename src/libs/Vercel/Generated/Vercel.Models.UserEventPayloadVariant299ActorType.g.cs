
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant299ActorType
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
    public static class UserEventPayloadVariant299ActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant299ActorType value)
        {
            return value switch
            {
                UserEventPayloadVariant299ActorType.Admin => "admin",
                UserEventPayloadVariant299ActorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant299ActorType? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserEventPayloadVariant299ActorType.Admin,
                "user" => UserEventPayloadVariant299ActorType.User,
                _ => null,
            };
        }
    }
}