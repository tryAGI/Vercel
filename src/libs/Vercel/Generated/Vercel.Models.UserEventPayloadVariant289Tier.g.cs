
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant289Tier
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
    public static class UserEventPayloadVariant289TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant289Tier value)
        {
            return value switch
            {
                UserEventPayloadVariant289Tier.Plus => "plus",
                UserEventPayloadVariant289Tier.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant289Tier? ToEnum(string value)
        {
            return value switch
            {
                "plus" => UserEventPayloadVariant289Tier.Plus,
                "pro" => UserEventPayloadVariant289Tier.Pro,
                _ => null,
            };
        }
    }
}