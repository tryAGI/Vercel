
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant97ToAccountType
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
    public static class UserEventPayloadVariant97ToAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant97ToAccountType value)
        {
            return value switch
            {
                UserEventPayloadVariant97ToAccountType.Team => "team",
                UserEventPayloadVariant97ToAccountType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant97ToAccountType? ToEnum(string value)
        {
            return value switch
            {
                "team" => UserEventPayloadVariant97ToAccountType.Team,
                "user" => UserEventPayloadVariant97ToAccountType.User,
                _ => null,
            };
        }
    }
}