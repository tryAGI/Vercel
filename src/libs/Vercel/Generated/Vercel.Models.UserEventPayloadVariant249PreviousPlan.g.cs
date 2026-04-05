
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant249PreviousPlan
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
    public static class UserEventPayloadVariant249PreviousPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant249PreviousPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant249PreviousPlan.Enterprise => "enterprise",
                UserEventPayloadVariant249PreviousPlan.Hobby => "hobby",
                UserEventPayloadVariant249PreviousPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant249PreviousPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant249PreviousPlan.Enterprise,
                "hobby" => UserEventPayloadVariant249PreviousPlan.Hobby,
                "pro" => UserEventPayloadVariant249PreviousPlan.Pro,
                _ => null,
            };
        }
    }
}