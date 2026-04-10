
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant98FromAccountType
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
    public static class UserEventPayloadVariant98FromAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant98FromAccountType value)
        {
            return value switch
            {
                UserEventPayloadVariant98FromAccountType.Team => "team",
                UserEventPayloadVariant98FromAccountType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant98FromAccountType? ToEnum(string value)
        {
            return value switch
            {
                "team" => UserEventPayloadVariant98FromAccountType.Team,
                "user" => UserEventPayloadVariant98FromAccountType.User,
                _ => null,
            };
        }
    }
}