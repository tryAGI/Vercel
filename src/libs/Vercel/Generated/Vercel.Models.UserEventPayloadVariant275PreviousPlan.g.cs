
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant275PreviousPlan
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
    public static class UserEventPayloadVariant275PreviousPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant275PreviousPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant275PreviousPlan.Enterprise => "enterprise",
                UserEventPayloadVariant275PreviousPlan.Hobby => "hobby",
                UserEventPayloadVariant275PreviousPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant275PreviousPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant275PreviousPlan.Enterprise,
                "hobby" => UserEventPayloadVariant275PreviousPlan.Hobby,
                "pro" => UserEventPayloadVariant275PreviousPlan.Pro,
                _ => null,
            };
        }
    }
}