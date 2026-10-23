
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared52fb994527107e75ResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKShared52fb994527107e75ResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared52fb994527107e75ResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKShared52fb994527107e75ResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKShared52fb994527107e75ResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKShared52fb994527107e75ResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKShared52fb994527107e75ResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared52fb994527107e75ResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKShared52fb994527107e75ResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKShared52fb994527107e75ResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKShared52fb994527107e75ResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKShared52fb994527107e75ResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}