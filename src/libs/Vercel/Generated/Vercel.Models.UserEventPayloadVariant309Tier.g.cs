
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant309Tier
    {
        /// <summary>
        /// 
        /// </summary>
        Plus,
        /// <summary>
        /// 
        /// </summary>
        Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant309TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant309Tier value)
        {
            return value switch
            {
                UserEventPayloadVariant309Tier.Plus => "plus",
                UserEventPayloadVariant309Tier.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant309Tier? ToEnum(string value)
        {
            return value switch
            {
                "plus" => UserEventPayloadVariant309Tier.Plus,
                "pro" => UserEventPayloadVariant309Tier.Pro,
                _ => null,
            };
        }
    }
}