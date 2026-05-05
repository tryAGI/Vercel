
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant276PreviousPlan
    {
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        Hobby,
        /// <summary>
        /// 
        /// </summary>
        Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant276PreviousPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant276PreviousPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant276PreviousPlan.Enterprise => "enterprise",
                UserEventPayloadVariant276PreviousPlan.Hobby => "hobby",
                UserEventPayloadVariant276PreviousPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant276PreviousPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant276PreviousPlan.Enterprise,
                "hobby" => UserEventPayloadVariant276PreviousPlan.Hobby,
                "pro" => UserEventPayloadVariant276PreviousPlan.Pro,
                _ => null,
            };
        }
    }
}