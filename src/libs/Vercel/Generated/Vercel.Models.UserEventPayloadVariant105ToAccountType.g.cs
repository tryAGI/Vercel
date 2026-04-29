
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant105ToAccountType
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
    public static class UserEventPayloadVariant105ToAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant105ToAccountType value)
        {
            return value switch
            {
                UserEventPayloadVariant105ToAccountType.Team => "team",
                UserEventPayloadVariant105ToAccountType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant105ToAccountType? ToEnum(string value)
        {
            return value switch
            {
                "team" => UserEventPayloadVariant105ToAccountType.Team,
                "user" => UserEventPayloadVariant105ToAccountType.User,
                _ => null,
            };
        }
    }
}