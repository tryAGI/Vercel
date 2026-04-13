
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant287Tier
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
    public static class UserEventPayloadVariant287TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant287Tier value)
        {
            return value switch
            {
                UserEventPayloadVariant287Tier.Plus => "plus",
                UserEventPayloadVariant287Tier.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant287Tier? ToEnum(string value)
        {
            return value switch
            {
                "plus" => UserEventPayloadVariant287Tier.Plus,
                "pro" => UserEventPayloadVariant287Tier.Pro,
                _ => null,
            };
        }
    }
}