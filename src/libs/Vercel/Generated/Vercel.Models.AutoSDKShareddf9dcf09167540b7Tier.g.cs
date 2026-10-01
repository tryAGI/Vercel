
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareddf9dcf09167540b7Tier
    {
        /// <summary>
        ///
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareddf9dcf09167540b7TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareddf9dcf09167540b7Tier value)
        {
            return value switch
            {
                AutoSDKShareddf9dcf09167540b7Tier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareddf9dcf09167540b7Tier? ToEnum(string value)
        {
            return value switch
            {
                "priority" => AutoSDKShareddf9dcf09167540b7Tier.Priority,
                _ => null,
            };
        }
    }
}