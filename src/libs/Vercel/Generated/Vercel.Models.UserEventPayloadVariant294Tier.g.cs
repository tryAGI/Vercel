
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant294Tier
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
    public static class UserEventPayloadVariant294TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant294Tier value)
        {
            return value switch
            {
                UserEventPayloadVariant294Tier.Plus => "plus",
                UserEventPayloadVariant294Tier.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant294Tier? ToEnum(string value)
        {
            return value switch
            {
                "plus" => UserEventPayloadVariant294Tier.Plus,
                "pro" => UserEventPayloadVariant294Tier.Pro,
                _ => null,
            };
        }
    }
}