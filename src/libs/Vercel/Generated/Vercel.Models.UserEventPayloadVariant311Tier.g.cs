
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant311Tier
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
    public static class UserEventPayloadVariant311TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant311Tier value)
        {
            return value switch
            {
                UserEventPayloadVariant311Tier.Plus => "plus",
                UserEventPayloadVariant311Tier.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant311Tier? ToEnum(string value)
        {
            return value switch
            {
                "plus" => UserEventPayloadVariant311Tier.Plus,
                "pro" => UserEventPayloadVariant311Tier.Pro,
                _ => null,
            };
        }
    }
}