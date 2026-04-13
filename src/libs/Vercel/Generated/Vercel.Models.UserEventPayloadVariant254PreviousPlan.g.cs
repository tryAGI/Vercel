
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant254PreviousPlan
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
    public static class UserEventPayloadVariant254PreviousPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant254PreviousPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant254PreviousPlan.Enterprise => "enterprise",
                UserEventPayloadVariant254PreviousPlan.Hobby => "hobby",
                UserEventPayloadVariant254PreviousPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant254PreviousPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant254PreviousPlan.Enterprise,
                "hobby" => UserEventPayloadVariant254PreviousPlan.Hobby,
                "pro" => UserEventPayloadVariant254PreviousPlan.Pro,
                _ => null,
            };
        }
    }
}