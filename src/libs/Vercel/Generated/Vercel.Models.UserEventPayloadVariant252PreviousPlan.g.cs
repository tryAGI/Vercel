
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant252PreviousPlan
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
    public static class UserEventPayloadVariant252PreviousPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant252PreviousPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant252PreviousPlan.Enterprise => "enterprise",
                UserEventPayloadVariant252PreviousPlan.Hobby => "hobby",
                UserEventPayloadVariant252PreviousPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant252PreviousPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant252PreviousPlan.Enterprise,
                "hobby" => UserEventPayloadVariant252PreviousPlan.Hobby,
                "pro" => UserEventPayloadVariant252PreviousPlan.Pro,
                _ => null,
            };
        }
    }
}