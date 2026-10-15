
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1006e75c11b11a21Tier
    {
        /// <summary>
        ///
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared1006e75c11b11a21TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1006e75c11b11a21Tier value)
        {
            return value switch
            {
                AutoSDKShared1006e75c11b11a21Tier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1006e75c11b11a21Tier? ToEnum(string value)
        {
            return value switch
            {
                "priority" => AutoSDKShared1006e75c11b11a21Tier.Priority,
                _ => null,
            };
        }
    }
}