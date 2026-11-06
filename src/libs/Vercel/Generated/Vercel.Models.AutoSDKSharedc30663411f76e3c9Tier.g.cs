
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc30663411f76e3c9Tier
    {
        /// <summary>
        ///
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedc30663411f76e3c9TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc30663411f76e3c9Tier value)
        {
            return value switch
            {
                AutoSDKSharedc30663411f76e3c9Tier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc30663411f76e3c9Tier? ToEnum(string value)
        {
            return value switch
            {
                "priority" => AutoSDKSharedc30663411f76e3c9Tier.Priority,
                _ => null,
            };
        }
    }
}