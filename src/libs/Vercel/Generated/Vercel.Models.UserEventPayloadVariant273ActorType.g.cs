
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant273ActorType
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
    public static class UserEventPayloadVariant273ActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant273ActorType value)
        {
            return value switch
            {
                UserEventPayloadVariant273ActorType.Admin => "admin",
                UserEventPayloadVariant273ActorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant273ActorType? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserEventPayloadVariant273ActorType.Admin,
                "user" => UserEventPayloadVariant273ActorType.User,
                _ => null,
            };
        }
    }
}