
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant265PreviousPlan
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
    public static class UserEventPayloadVariant265PreviousPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant265PreviousPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant265PreviousPlan.Enterprise => "enterprise",
                UserEventPayloadVariant265PreviousPlan.Hobby => "hobby",
                UserEventPayloadVariant265PreviousPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant265PreviousPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant265PreviousPlan.Enterprise,
                "hobby" => UserEventPayloadVariant265PreviousPlan.Hobby,
                "pro" => UserEventPayloadVariant265PreviousPlan.Pro,
                _ => null,
            };
        }
    }
}