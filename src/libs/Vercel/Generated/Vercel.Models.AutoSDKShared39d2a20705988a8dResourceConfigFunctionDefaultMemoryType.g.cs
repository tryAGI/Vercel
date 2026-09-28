
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared39d2a20705988a8dResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKShared39d2a20705988a8dResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared39d2a20705988a8dResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKShared39d2a20705988a8dResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKShared39d2a20705988a8dResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKShared39d2a20705988a8dResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKShared39d2a20705988a8dResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared39d2a20705988a8dResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKShared39d2a20705988a8dResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKShared39d2a20705988a8dResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKShared39d2a20705988a8dResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKShared39d2a20705988a8dResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}