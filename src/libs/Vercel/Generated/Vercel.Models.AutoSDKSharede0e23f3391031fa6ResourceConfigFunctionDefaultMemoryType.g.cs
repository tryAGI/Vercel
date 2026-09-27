
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede0e23f3391031fa6ResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKSharede0e23f3391031fa6ResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede0e23f3391031fa6ResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKSharede0e23f3391031fa6ResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKSharede0e23f3391031fa6ResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKSharede0e23f3391031fa6ResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKSharede0e23f3391031fa6ResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede0e23f3391031fa6ResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKSharede0e23f3391031fa6ResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKSharede0e23f3391031fa6ResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKSharede0e23f3391031fa6ResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKSharede0e23f3391031fa6ResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}