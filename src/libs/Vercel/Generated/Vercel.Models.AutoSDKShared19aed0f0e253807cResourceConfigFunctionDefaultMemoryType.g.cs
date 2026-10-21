
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared19aed0f0e253807cResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKShared19aed0f0e253807cResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared19aed0f0e253807cResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKShared19aed0f0e253807cResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKShared19aed0f0e253807cResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKShared19aed0f0e253807cResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKShared19aed0f0e253807cResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared19aed0f0e253807cResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKShared19aed0f0e253807cResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKShared19aed0f0e253807cResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKShared19aed0f0e253807cResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKShared19aed0f0e253807cResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}