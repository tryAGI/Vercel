
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant262PreviousPlan
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
    public static class UserEventPayloadVariant262PreviousPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant262PreviousPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant262PreviousPlan.Enterprise => "enterprise",
                UserEventPayloadVariant262PreviousPlan.Hobby => "hobby",
                UserEventPayloadVariant262PreviousPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant262PreviousPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant262PreviousPlan.Enterprise,
                "hobby" => UserEventPayloadVariant262PreviousPlan.Hobby,
                "pro" => UserEventPayloadVariant262PreviousPlan.Pro,
                _ => null,
            };
        }
    }
}