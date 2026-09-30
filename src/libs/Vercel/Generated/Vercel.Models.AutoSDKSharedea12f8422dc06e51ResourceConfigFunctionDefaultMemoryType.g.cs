
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedea12f8422dc06e51ResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKSharedea12f8422dc06e51ResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedea12f8422dc06e51ResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKSharedea12f8422dc06e51ResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKSharedea12f8422dc06e51ResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKSharedea12f8422dc06e51ResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKSharedea12f8422dc06e51ResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedea12f8422dc06e51ResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKSharedea12f8422dc06e51ResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKSharedea12f8422dc06e51ResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKSharedea12f8422dc06e51ResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKSharedea12f8422dc06e51ResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}