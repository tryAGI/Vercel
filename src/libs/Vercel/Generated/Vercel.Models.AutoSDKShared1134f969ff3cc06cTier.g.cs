
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1134f969ff3cc06cTier
    {
        /// <summary>
        ///
        /// </summary>
        Critical,
        /// <summary>
        ///
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared1134f969ff3cc06cTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1134f969ff3cc06cTier value)
        {
            return value switch
            {
                AutoSDKShared1134f969ff3cc06cTier.Critical => "critical",
                AutoSDKShared1134f969ff3cc06cTier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1134f969ff3cc06cTier? ToEnum(string value)
        {
            return value switch
            {
                "critical" => AutoSDKShared1134f969ff3cc06cTier.Critical,
                "priority" => AutoSDKShared1134f969ff3cc06cTier.Priority,
                _ => null,
            };
        }
    }
}