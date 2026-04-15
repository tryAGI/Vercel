
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant293Tier
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
    public static class UserEventPayloadVariant293TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant293Tier value)
        {
            return value switch
            {
                UserEventPayloadVariant293Tier.Plus => "plus",
                UserEventPayloadVariant293Tier.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant293Tier? ToEnum(string value)
        {
            return value switch
            {
                "plus" => UserEventPayloadVariant293Tier.Plus,
                "pro" => UserEventPayloadVariant293Tier.Pro,
                _ => null,
            };
        }
    }
}