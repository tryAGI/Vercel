
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared26233794f6c8981bDefaultResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKShared26233794f6c8981bDefaultResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared26233794f6c8981bDefaultResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKShared26233794f6c8981bDefaultResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKShared26233794f6c8981bDefaultResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKShared26233794f6c8981bDefaultResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKShared26233794f6c8981bDefaultResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared26233794f6c8981bDefaultResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKShared26233794f6c8981bDefaultResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKShared26233794f6c8981bDefaultResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKShared26233794f6c8981bDefaultResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKShared26233794f6c8981bDefaultResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}