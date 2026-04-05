
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant282Tier
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
    public static class UserEventPayloadVariant282TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant282Tier value)
        {
            return value switch
            {
                UserEventPayloadVariant282Tier.Plus => "plus",
                UserEventPayloadVariant282Tier.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant282Tier? ToEnum(string value)
        {
            return value switch
            {
                "plus" => UserEventPayloadVariant282Tier.Plus,
                "pro" => UserEventPayloadVariant282Tier.Pro,
                _ => null,
            };
        }
    }
}