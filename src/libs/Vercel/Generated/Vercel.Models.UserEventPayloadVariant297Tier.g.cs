
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant297Tier
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
    public static class UserEventPayloadVariant297TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant297Tier value)
        {
            return value switch
            {
                UserEventPayloadVariant297Tier.Plus => "plus",
                UserEventPayloadVariant297Tier.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant297Tier? ToEnum(string value)
        {
            return value switch
            {
                "plus" => UserEventPayloadVariant297Tier.Plus,
                "pro" => UserEventPayloadVariant297Tier.Pro,
                _ => null,
            };
        }
    }
}