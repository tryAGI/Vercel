
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant255PreviousPlan
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
    public static class UserEventPayloadVariant255PreviousPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant255PreviousPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant255PreviousPlan.Enterprise => "enterprise",
                UserEventPayloadVariant255PreviousPlan.Hobby => "hobby",
                UserEventPayloadVariant255PreviousPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant255PreviousPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant255PreviousPlan.Enterprise,
                "hobby" => UserEventPayloadVariant255PreviousPlan.Hobby,
                "pro" => UserEventPayloadVariant255PreviousPlan.Pro,
                _ => null,
            };
        }
    }
}