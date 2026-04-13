
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant99FromAccountType
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
    public static class UserEventPayloadVariant99FromAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant99FromAccountType value)
        {
            return value switch
            {
                UserEventPayloadVariant99FromAccountType.Team => "team",
                UserEventPayloadVariant99FromAccountType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant99FromAccountType? ToEnum(string value)
        {
            return value switch
            {
                "team" => UserEventPayloadVariant99FromAccountType.Team,
                "user" => UserEventPayloadVariant99FromAccountType.User,
                _ => null,
            };
        }
    }
}