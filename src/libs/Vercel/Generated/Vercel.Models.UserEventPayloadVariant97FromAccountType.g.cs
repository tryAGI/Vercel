
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant97FromAccountType
    {
        /// <summary>
        /// 
        /// </summary>
        Team,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant97FromAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant97FromAccountType value)
        {
            return value switch
            {
                UserEventPayloadVariant97FromAccountType.Team => "team",
                UserEventPayloadVariant97FromAccountType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant97FromAccountType? ToEnum(string value)
        {
            return value switch
            {
                "team" => UserEventPayloadVariant97FromAccountType.Team,
                "user" => UserEventPayloadVariant97FromAccountType.User,
                _ => null,
            };
        }
    }
}