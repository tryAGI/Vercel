
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant98ToAccountType
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
    public static class UserEventPayloadVariant98ToAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant98ToAccountType value)
        {
            return value switch
            {
                UserEventPayloadVariant98ToAccountType.Team => "team",
                UserEventPayloadVariant98ToAccountType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant98ToAccountType? ToEnum(string value)
        {
            return value switch
            {
                "team" => UserEventPayloadVariant98ToAccountType.Team,
                "user" => UserEventPayloadVariant98ToAccountType.User,
                _ => null,
            };
        }
    }
}