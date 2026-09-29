
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede7e7c058d3e19656ResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKSharede7e7c058d3e19656ResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede7e7c058d3e19656ResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKSharede7e7c058d3e19656ResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKSharede7e7c058d3e19656ResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKSharede7e7c058d3e19656ResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKSharede7e7c058d3e19656ResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede7e7c058d3e19656ResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKSharede7e7c058d3e19656ResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKSharede7e7c058d3e19656ResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKSharede7e7c058d3e19656ResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKSharede7e7c058d3e19656ResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}