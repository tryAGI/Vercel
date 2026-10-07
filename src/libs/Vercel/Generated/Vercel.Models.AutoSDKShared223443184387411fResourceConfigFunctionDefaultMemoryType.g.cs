
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared223443184387411fResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKShared223443184387411fResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared223443184387411fResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKShared223443184387411fResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKShared223443184387411fResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKShared223443184387411fResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKShared223443184387411fResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared223443184387411fResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKShared223443184387411fResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKShared223443184387411fResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKShared223443184387411fResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKShared223443184387411fResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}