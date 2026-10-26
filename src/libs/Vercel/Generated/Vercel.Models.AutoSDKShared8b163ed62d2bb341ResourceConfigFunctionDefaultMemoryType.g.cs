
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8b163ed62d2bb341ResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKShared8b163ed62d2bb341ResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8b163ed62d2bb341ResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKShared8b163ed62d2bb341ResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKShared8b163ed62d2bb341ResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKShared8b163ed62d2bb341ResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKShared8b163ed62d2bb341ResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8b163ed62d2bb341ResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKShared8b163ed62d2bb341ResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKShared8b163ed62d2bb341ResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKShared8b163ed62d2bb341ResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKShared8b163ed62d2bb341ResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}