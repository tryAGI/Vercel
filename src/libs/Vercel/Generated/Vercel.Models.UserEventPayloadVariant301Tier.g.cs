
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant301Tier
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
    public static class UserEventPayloadVariant301TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant301Tier value)
        {
            return value switch
            {
                UserEventPayloadVariant301Tier.Plus => "plus",
                UserEventPayloadVariant301Tier.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant301Tier? ToEnum(string value)
        {
            return value switch
            {
                "plus" => UserEventPayloadVariant301Tier.Plus,
                "pro" => UserEventPayloadVariant301Tier.Pro,
                _ => null,
            };
        }
    }
}