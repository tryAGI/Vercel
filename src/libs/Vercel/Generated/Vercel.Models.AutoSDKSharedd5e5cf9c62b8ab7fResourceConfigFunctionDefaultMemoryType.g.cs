
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}