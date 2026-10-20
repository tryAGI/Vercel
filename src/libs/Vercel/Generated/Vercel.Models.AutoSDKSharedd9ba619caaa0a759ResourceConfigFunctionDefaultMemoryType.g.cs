
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd9ba619caaa0a759ResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKSharedd9ba619caaa0a759ResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd9ba619caaa0a759ResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKSharedd9ba619caaa0a759ResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKSharedd9ba619caaa0a759ResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKSharedd9ba619caaa0a759ResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKSharedd9ba619caaa0a759ResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd9ba619caaa0a759ResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKSharedd9ba619caaa0a759ResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKSharedd9ba619caaa0a759ResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKSharedd9ba619caaa0a759ResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKSharedd9ba619caaa0a759ResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}