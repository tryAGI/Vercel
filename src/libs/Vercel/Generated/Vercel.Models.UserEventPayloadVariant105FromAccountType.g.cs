
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant105FromAccountType
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
    public static class UserEventPayloadVariant105FromAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant105FromAccountType value)
        {
            return value switch
            {
                UserEventPayloadVariant105FromAccountType.Team => "team",
                UserEventPayloadVariant105FromAccountType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant105FromAccountType? ToEnum(string value)
        {
            return value switch
            {
                "team" => UserEventPayloadVariant105FromAccountType.Team,
                "user" => UserEventPayloadVariant105FromAccountType.User,
                _ => null,
            };
        }
    }
}