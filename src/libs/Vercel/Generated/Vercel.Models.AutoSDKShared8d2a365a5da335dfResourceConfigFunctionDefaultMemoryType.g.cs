
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8d2a365a5da335dfResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKShared8d2a365a5da335dfResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8d2a365a5da335dfResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKShared8d2a365a5da335dfResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKShared8d2a365a5da335dfResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKShared8d2a365a5da335dfResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKShared8d2a365a5da335dfResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8d2a365a5da335dfResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKShared8d2a365a5da335dfResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKShared8d2a365a5da335dfResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKShared8d2a365a5da335dfResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKShared8d2a365a5da335dfResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}