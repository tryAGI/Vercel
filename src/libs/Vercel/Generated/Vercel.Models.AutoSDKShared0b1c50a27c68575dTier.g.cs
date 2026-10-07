
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0b1c50a27c68575dTier
    {
        /// <summary>
        ///
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0b1c50a27c68575dTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0b1c50a27c68575dTier value)
        {
            return value switch
            {
                AutoSDKShared0b1c50a27c68575dTier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0b1c50a27c68575dTier? ToEnum(string value)
        {
            return value switch
            {
                "priority" => AutoSDKShared0b1c50a27c68575dTier.Priority,
                _ => null,
            };
        }
    }
}