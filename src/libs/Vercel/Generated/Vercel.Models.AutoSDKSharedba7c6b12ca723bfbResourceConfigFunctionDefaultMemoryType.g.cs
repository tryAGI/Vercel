
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedba7c6b12ca723bfbResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKSharedba7c6b12ca723bfbResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedba7c6b12ca723bfbResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKSharedba7c6b12ca723bfbResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKSharedba7c6b12ca723bfbResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKSharedba7c6b12ca723bfbResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKSharedba7c6b12ca723bfbResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedba7c6b12ca723bfbResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKSharedba7c6b12ca723bfbResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKSharedba7c6b12ca723bfbResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKSharedba7c6b12ca723bfbResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKSharedba7c6b12ca723bfbResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}