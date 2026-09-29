
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared26233794f6c8981bResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKShared26233794f6c8981bResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared26233794f6c8981bResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKShared26233794f6c8981bResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKShared26233794f6c8981bResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKShared26233794f6c8981bResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKShared26233794f6c8981bResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared26233794f6c8981bResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKShared26233794f6c8981bResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKShared26233794f6c8981bResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKShared26233794f6c8981bResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKShared26233794f6c8981bResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}