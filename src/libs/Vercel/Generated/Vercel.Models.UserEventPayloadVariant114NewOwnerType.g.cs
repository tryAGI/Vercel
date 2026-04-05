
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerType
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant114NewOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerType value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "user" => UserEventPayloadVariant114NewOwnerType.User,
                _ => null,
            };
        }
    }
}