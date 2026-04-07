
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant250PreviousPlan
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
    public static class UserEventPayloadVariant250PreviousPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant250PreviousPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant250PreviousPlan.Enterprise => "enterprise",
                UserEventPayloadVariant250PreviousPlan.Hobby => "hobby",
                UserEventPayloadVariant250PreviousPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant250PreviousPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant250PreviousPlan.Enterprise,
                "hobby" => UserEventPayloadVariant250PreviousPlan.Hobby,
                "pro" => UserEventPayloadVariant250PreviousPlan.Pro,
                _ => null,
            };
        }
    }
}