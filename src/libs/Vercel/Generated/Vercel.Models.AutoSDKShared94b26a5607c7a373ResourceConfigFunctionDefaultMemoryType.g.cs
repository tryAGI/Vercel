
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared94b26a5607c7a373ResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKShared94b26a5607c7a373ResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared94b26a5607c7a373ResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKShared94b26a5607c7a373ResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKShared94b26a5607c7a373ResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKShared94b26a5607c7a373ResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKShared94b26a5607c7a373ResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared94b26a5607c7a373ResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKShared94b26a5607c7a373ResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKShared94b26a5607c7a373ResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKShared94b26a5607c7a373ResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKShared94b26a5607c7a373ResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}