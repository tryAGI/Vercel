
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant312Tier
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
    public static class UserEventPayloadVariant312TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant312Tier value)
        {
            return value switch
            {
                UserEventPayloadVariant312Tier.Plus => "plus",
                UserEventPayloadVariant312Tier.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant312Tier? ToEnum(string value)
        {
            return value switch
            {
                "plus" => UserEventPayloadVariant312Tier.Plus,
                "pro" => UserEventPayloadVariant312Tier.Pro,
                _ => null,
            };
        }
    }
}