
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant99ToAccountType
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
    public static class UserEventPayloadVariant99ToAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant99ToAccountType value)
        {
            return value switch
            {
                UserEventPayloadVariant99ToAccountType.Team => "team",
                UserEventPayloadVariant99ToAccountType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant99ToAccountType? ToEnum(string value)
        {
            return value switch
            {
                "team" => UserEventPayloadVariant99ToAccountType.Team,
                "user" => UserEventPayloadVariant99ToAccountType.User,
                _ => null,
            };
        }
    }
}