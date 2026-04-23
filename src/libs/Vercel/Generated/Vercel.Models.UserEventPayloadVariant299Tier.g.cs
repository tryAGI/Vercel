
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant299Tier
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
    public static class UserEventPayloadVariant299TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant299Tier value)
        {
            return value switch
            {
                UserEventPayloadVariant299Tier.Plus => "plus",
                UserEventPayloadVariant299Tier.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant299Tier? ToEnum(string value)
        {
            return value switch
            {
                "plus" => UserEventPayloadVariant299Tier.Plus,
                "pro" => UserEventPayloadVariant299Tier.Pro,
                _ => null,
            };
        }
    }
}