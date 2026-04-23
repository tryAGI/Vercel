
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant264PreviousPlan
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
    public static class UserEventPayloadVariant264PreviousPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant264PreviousPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant264PreviousPlan.Enterprise => "enterprise",
                UserEventPayloadVariant264PreviousPlan.Hobby => "hobby",
                UserEventPayloadVariant264PreviousPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant264PreviousPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant264PreviousPlan.Enterprise,
                "hobby" => UserEventPayloadVariant264PreviousPlan.Hobby,
                "pro" => UserEventPayloadVariant264PreviousPlan.Pro,
                _ => null,
            };
        }
    }
}