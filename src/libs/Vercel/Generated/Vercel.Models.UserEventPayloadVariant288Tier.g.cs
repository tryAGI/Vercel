
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant288Tier
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
    public static class UserEventPayloadVariant288TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant288Tier value)
        {
            return value switch
            {
                UserEventPayloadVariant288Tier.Plus => "plus",
                UserEventPayloadVariant288Tier.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant288Tier? ToEnum(string value)
        {
            return value switch
            {
                "plus" => UserEventPayloadVariant288Tier.Plus,
                "pro" => UserEventPayloadVariant288Tier.Pro,
                _ => null,
            };
        }
    }
}