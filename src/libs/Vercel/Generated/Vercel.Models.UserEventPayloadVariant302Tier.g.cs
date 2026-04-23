
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant302Tier
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
    public static class UserEventPayloadVariant302TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant302Tier value)
        {
            return value switch
            {
                UserEventPayloadVariant302Tier.Plus => "plus",
                UserEventPayloadVariant302Tier.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant302Tier? ToEnum(string value)
        {
            return value switch
            {
                "plus" => UserEventPayloadVariant302Tier.Plus,
                "pro" => UserEventPayloadVariant302Tier.Pro,
                _ => null,
            };
        }
    }
}