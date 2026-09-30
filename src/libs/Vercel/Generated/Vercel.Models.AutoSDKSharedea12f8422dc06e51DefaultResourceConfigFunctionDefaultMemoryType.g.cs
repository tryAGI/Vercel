
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedea12f8422dc06e51DefaultResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKSharedea12f8422dc06e51DefaultResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedea12f8422dc06e51DefaultResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKSharedea12f8422dc06e51DefaultResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKSharedea12f8422dc06e51DefaultResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKSharedea12f8422dc06e51DefaultResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKSharedea12f8422dc06e51DefaultResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedea12f8422dc06e51DefaultResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKSharedea12f8422dc06e51DefaultResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKSharedea12f8422dc06e51DefaultResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKSharedea12f8422dc06e51DefaultResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKSharedea12f8422dc06e51DefaultResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}