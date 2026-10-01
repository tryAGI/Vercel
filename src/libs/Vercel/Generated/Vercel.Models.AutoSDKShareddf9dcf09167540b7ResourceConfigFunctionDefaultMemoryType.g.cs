
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareddf9dcf09167540b7ResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKShareddf9dcf09167540b7ResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareddf9dcf09167540b7ResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKShareddf9dcf09167540b7ResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKShareddf9dcf09167540b7ResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKShareddf9dcf09167540b7ResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKShareddf9dcf09167540b7ResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareddf9dcf09167540b7ResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKShareddf9dcf09167540b7ResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKShareddf9dcf09167540b7ResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKShareddf9dcf09167540b7ResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKShareddf9dcf09167540b7ResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}