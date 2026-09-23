
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd5e5cf9c62b8ab7fTier
    {
        /// <summary>
        ///
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedd5e5cf9c62b8ab7fTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd5e5cf9c62b8ab7fTier value)
        {
            return value switch
            {
                AutoSDKSharedd5e5cf9c62b8ab7fTier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd5e5cf9c62b8ab7fTier? ToEnum(string value)
        {
            return value switch
            {
                "priority" => AutoSDKSharedd5e5cf9c62b8ab7fTier.Priority,
                _ => null,
            };
        }
    }
}