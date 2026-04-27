
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant303Tier
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
    public static class UserEventPayloadVariant303TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant303Tier value)
        {
            return value switch
            {
                UserEventPayloadVariant303Tier.Plus => "plus",
                UserEventPayloadVariant303Tier.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant303Tier? ToEnum(string value)
        {
            return value switch
            {
                "plus" => UserEventPayloadVariant303Tier.Plus,
                "pro" => UserEventPayloadVariant303Tier.Pro,
                _ => null,
            };
        }
    }
}