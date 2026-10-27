
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbbf450e6ecd4e724FunctionDefaultMemoryType
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
    public static class AutoSDKSharedbbf450e6ecd4e724FunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbbf450e6ecd4e724FunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKSharedbbf450e6ecd4e724FunctionDefaultMemoryType.Performance => "performance",
                AutoSDKSharedbbf450e6ecd4e724FunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKSharedbbf450e6ecd4e724FunctionDefaultMemoryType.Standard => "standard",
                AutoSDKSharedbbf450e6ecd4e724FunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbbf450e6ecd4e724FunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKSharedbbf450e6ecd4e724FunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKSharedbbf450e6ecd4e724FunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKSharedbbf450e6ecd4e724FunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKSharedbbf450e6ecd4e724FunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}