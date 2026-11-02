
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared39497871754bda72Tier
    {
        /// <summary>
        ///
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared39497871754bda72TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared39497871754bda72Tier value)
        {
            return value switch
            {
                AutoSDKShared39497871754bda72Tier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared39497871754bda72Tier? ToEnum(string value)
        {
            return value switch
            {
                "priority" => AutoSDKShared39497871754bda72Tier.Priority,
                _ => null,
            };
        }
    }
}