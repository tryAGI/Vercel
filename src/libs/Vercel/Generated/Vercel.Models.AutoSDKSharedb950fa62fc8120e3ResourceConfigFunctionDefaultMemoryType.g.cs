
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb950fa62fc8120e3ResourceConfigFunctionDefaultMemoryType
    {
        /// <summary>
        ///
        /// </summary>
        Performance,
        /// <summary>
        ///
        /// </summary>
        PerformanceXl,
        /// <summary>
        ///
        /// </summary>
        Standard,
        /// <summary>
        ///
        /// </summary>
        StandardLegacy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedb950fa62fc8120e3ResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb950fa62fc8120e3ResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKSharedb950fa62fc8120e3ResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKSharedb950fa62fc8120e3ResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKSharedb950fa62fc8120e3ResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKSharedb950fa62fc8120e3ResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb950fa62fc8120e3ResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKSharedb950fa62fc8120e3ResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKSharedb950fa62fc8120e3ResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKSharedb950fa62fc8120e3ResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKSharedb950fa62fc8120e3ResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}