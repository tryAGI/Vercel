
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc1c2f92d02e0feb6Tier
    {
        /// <summary>
        ///
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedc1c2f92d02e0feb6TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc1c2f92d02e0feb6Tier value)
        {
            return value switch
            {
                AutoSDKSharedc1c2f92d02e0feb6Tier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc1c2f92d02e0feb6Tier? ToEnum(string value)
        {
            return value switch
            {
                "priority" => AutoSDKSharedc1c2f92d02e0feb6Tier.Priority,
                _ => null,
            };
        }
    }
}