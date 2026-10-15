
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1006e75c11b11a21ResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKShared1006e75c11b11a21ResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1006e75c11b11a21ResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKShared1006e75c11b11a21ResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKShared1006e75c11b11a21ResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKShared1006e75c11b11a21ResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKShared1006e75c11b11a21ResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1006e75c11b11a21ResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKShared1006e75c11b11a21ResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKShared1006e75c11b11a21ResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKShared1006e75c11b11a21ResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKShared1006e75c11b11a21ResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}