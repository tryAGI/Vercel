
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared39d2a20705988a8dTier
    {
        /// <summary>
        ///
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared39d2a20705988a8dTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared39d2a20705988a8dTier value)
        {
            return value switch
            {
                AutoSDKShared39d2a20705988a8dTier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared39d2a20705988a8dTier? ToEnum(string value)
        {
            return value switch
            {
                "priority" => AutoSDKShared39d2a20705988a8dTier.Priority,
                _ => null,
            };
        }
    }
}