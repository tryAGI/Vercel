
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant272PreviousPlan
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
    public static class UserEventPayloadVariant272PreviousPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant272PreviousPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant272PreviousPlan.Enterprise => "enterprise",
                UserEventPayloadVariant272PreviousPlan.Hobby => "hobby",
                UserEventPayloadVariant272PreviousPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant272PreviousPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant272PreviousPlan.Enterprise,
                "hobby" => UserEventPayloadVariant272PreviousPlan.Hobby,
                "pro" => UserEventPayloadVariant272PreviousPlan.Pro,
                _ => null,
            };
        }
    }
}