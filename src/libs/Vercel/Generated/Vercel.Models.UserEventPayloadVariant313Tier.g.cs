
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant313Tier
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
    public static class UserEventPayloadVariant313TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant313Tier value)
        {
            return value switch
            {
                UserEventPayloadVariant313Tier.Plus => "plus",
                UserEventPayloadVariant313Tier.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant313Tier? ToEnum(string value)
        {
            return value switch
            {
                "plus" => UserEventPayloadVariant313Tier.Plus,
                "pro" => UserEventPayloadVariant313Tier.Pro,
                _ => null,
            };
        }
    }
}