
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda8d456fca5d8a771ResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKShareda8d456fca5d8a771ResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda8d456fca5d8a771ResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKShareda8d456fca5d8a771ResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKShareda8d456fca5d8a771ResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKShareda8d456fca5d8a771ResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKShareda8d456fca5d8a771ResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda8d456fca5d8a771ResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKShareda8d456fca5d8a771ResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKShareda8d456fca5d8a771ResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKShareda8d456fca5d8a771ResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKShareda8d456fca5d8a771ResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}