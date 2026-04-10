
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant285Tier
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
    public static class UserEventPayloadVariant285TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant285Tier value)
        {
            return value switch
            {
                UserEventPayloadVariant285Tier.Plus => "plus",
                UserEventPayloadVariant285Tier.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant285Tier? ToEnum(string value)
        {
            return value switch
            {
                "plus" => UserEventPayloadVariant285Tier.Plus,
                "pro" => UserEventPayloadVariant285Tier.Pro,
                _ => null,
            };
        }
    }
}