
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant286Tier
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
    public static class UserEventPayloadVariant286TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant286Tier value)
        {
            return value switch
            {
                UserEventPayloadVariant286Tier.Plus => "plus",
                UserEventPayloadVariant286Tier.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant286Tier? ToEnum(string value)
        {
            return value switch
            {
                "plus" => UserEventPayloadVariant286Tier.Plus,
                "pro" => UserEventPayloadVariant286Tier.Pro,
                _ => null,
            };
        }
    }
}