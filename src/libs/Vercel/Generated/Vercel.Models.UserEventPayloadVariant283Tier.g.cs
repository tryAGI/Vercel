
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant283Tier
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
    public static class UserEventPayloadVariant283TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant283Tier value)
        {
            return value switch
            {
                UserEventPayloadVariant283Tier.Plus => "plus",
                UserEventPayloadVariant283Tier.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant283Tier? ToEnum(string value)
        {
            return value switch
            {
                "plus" => UserEventPayloadVariant283Tier.Plus,
                "pro" => UserEventPayloadVariant283Tier.Pro,
                _ => null,
            };
        }
    }
}