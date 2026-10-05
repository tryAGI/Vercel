
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede052f139ff613de3ResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKSharede052f139ff613de3ResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede052f139ff613de3ResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKSharede052f139ff613de3ResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKSharede052f139ff613de3ResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKSharede052f139ff613de3ResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKSharede052f139ff613de3ResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede052f139ff613de3ResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKSharede052f139ff613de3ResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKSharede052f139ff613de3ResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKSharede052f139ff613de3ResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKSharede052f139ff613de3ResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}