
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}