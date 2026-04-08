
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant284Tier
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
    public static class UserEventPayloadVariant284TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant284Tier value)
        {
            return value switch
            {
                UserEventPayloadVariant284Tier.Plus => "plus",
                UserEventPayloadVariant284Tier.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant284Tier? ToEnum(string value)
        {
            return value switch
            {
                "plus" => UserEventPayloadVariant284Tier.Plus,
                "pro" => UserEventPayloadVariant284Tier.Pro,
                _ => null,
            };
        }
    }
}